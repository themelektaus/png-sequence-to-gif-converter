namespace PngSequenceToGifConverter;

public partial class MainForm : Form
{
    public class Frame
    {
        public string file;
        public string name;
        public int index;
        public Bitmap bitmap;
    }

    readonly List<Frame> frames = new();

    public MainForm()
    {
        InitializeComponent();
    }

    async void MainForm_Load(object sender, EventArgs e)
    {
        SetEnabled(false);

        var path = Config.instance.imageMagickPath;
        Control_ImageMagickPathLinkLabel.Text = Path.GetFullPath(path);
        Control_ImageMagickPathLinkLabel.Click += Control_ImageMagickPathLinkLabel_Click;

        Control_DelayField.Value = Config.instance.delay;
        Control_SkipField.Value = Config.instance.skip;
        Control_LoopField.Value = Config.instance.loop;
        Control_ScaleField.Value = Config.instance.scale;
        Control_TransparencyCheckbox.Checked = Config.instance.transparency;

        await RefreshFilesViewAsync();

        SetEnabled(true);
    }

    void Control_ImageMagickPathLinkLabel_Click(object sender, EventArgs e)
    {
        Dialog_FolderBrowser.SelectedPath = Control_ImageMagickPathLinkLabel.Text;
        if (Dialog_FolderBrowser.ShowDialog() == DialogResult.OK)
        {
            var path = Path.GetFullPath(Dialog_FolderBrowser.SelectedPath);
            Config.instance.imageMagickPath = Path.GetRelativePath(".", path);
            Config.Save();
            Control_ImageMagickPathLinkLabel.Text = path;
        }
    }

    async Task RefreshFilesViewAsync()
    {
        Control_FirstFrameIndex.Minimum = -1;
        Control_FirstFrameIndex.Maximum = 0;
        Control_FirstFrameIndex.Value = -1;

        Control_LastFrameIndex.Minimum = -1;
        Control_LastFrameIndex.Maximum = 0;
        Control_LastFrameIndex.Value = -1;

        foreach (var frame in frames)
            if (frame.bitmap is not null) 
                frame.bitmap.Dispose();

        Control_FilesView.Items.Clear();
        if (Control_FilesView.LargeImageList is not null)
            Control_FilesView.LargeImageList.Dispose();

        var imageList = new ImageList { ImageSize = new(64, 64) };
        Control_FilesView.LargeImageList = imageList;

        Control_FirstFrameIndex_Scroll(null, EventArgs.Empty);

        if (frames.Count == 0)
        {
            Control_FilesView.Items.Add("Drop files or folders here");
            RefreshPreview();
            return;
        }

        foreach (var frame in frames)
            frame.bitmap = await Task.Run(() => new Bitmap(frame.file));

        var bitmap = frames[0].bitmap;

        if (bitmap.Width < bitmap.Height)
        {
            var ratio = bitmap.Width / (float) bitmap.Height;
            imageList.ImageSize = new((int) Math.Round(64 * ratio), 64);
        }
        else if (bitmap.Width > bitmap.Height)
        {
            var ratio = bitmap.Height / (float) bitmap.Width;
            imageList.ImageSize = new(64, (int) Math.Round(64 * ratio));
        }

        foreach (var frame in frames)
        {
            Control_FilesView.Items.Add(new ListViewItem(frame.name, frame.index));
            imageList.Images.Add(frame.bitmap);
        }

        Control_FirstFrameIndex.Minimum = 0;
        Control_FirstFrameIndex.Maximum = frames.Count - 1;
        Control_FirstFrameIndex.Value = 0;

        Control_LastFrameIndex.Minimum = 0;
        Control_LastFrameIndex.Maximum = frames.Count - 1;
        Control_LastFrameIndex.Value = frames.Count - 1;

        RefreshPreview();
    }

    void Control_FilesView_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Link;
    }

    async void Control_FilesView_DragDrop(object sender, DragEventArgs e)
    {
        SetEnabled(false);

        frames.Clear();

        foreach (var file in (string[]) e.Data.GetData(DataFormats.FileDrop, false))
        {
            if (File.GetAttributes(file).HasFlag(FileAttributes.Directory))
            {
                var files = Directory.EnumerateFiles(file, "*.png", SearchOption.TopDirectoryOnly);
                frames.AddRange(files.Select(x => new Frame { file = x }));
                continue;
            }

            if (!file.EndsWith(".png"))
                continue;

            frames.Add(new Frame { file = file });
        }

        for (int i = 0; i < frames.Count; i++)
        {
            frames[i].name = Path.GetFileNameWithoutExtension(frames[i].file);
            frames[i].index = i;
        }

        await RefreshFilesViewAsync();

        SetEnabled(true);
    }

    async void Control_ConvertButton_Click(object sender, EventArgs e)
    {
        if (frames.Count == 0)
            return;

        SetEnabled(false);

        if (!Directory.Exists("Output"))
            Directory.CreateDirectory("Output");

        if (Directory.Exists("Temp"))
            Directory.Delete("Temp", true);

        Directory.CreateDirectory("Temp");

        int skip = 0;
        int index = 0;

        foreach (var frame in frames)
        {
            if (frame.index < Control_FirstFrameIndex.Value)
                continue;

            if (frame.index > Control_LastFrameIndex.Value)
                break;

            if (skip > 0)
            {
                skip--;
                continue;
            }
            skip = Config.instance.skip;

            File.Copy(frame.file, $"Temp\\{index++:D6}.png");
        }

        var imageMagickPath = Config.instance.imageMagickPath;

        string command;
        string arguments;

        string color = "";
        if (Config.instance.transparency)
        {
            command = @$"{imageMagickPath}\magick.exe";
            arguments = @"Temp\000000.png -format ""%[pixel:u.p{0,0}]\n"" info:";
            color = await ExecuteAsync(command, arguments);
            color = color.TrimEnd();
            if (!string.IsNullOrEmpty(color))
                color = $"-transparent {color.Replace(",0)", ",1)")}";
        }

        string scale = "";
        if (Config.instance.scale != 100)
            scale = $"-resize {Config.instance.scale}%";

        var output = $"Output\\{DateTime.Now.Ticks}.gif";

        command = @$"{imageMagickPath}\convert.exe";
        arguments = $"-verbose -delay {Config.instance.delay} -dispose previous "
            + @$"Temp\*.png -loop {Config.instance.loop} {scale} {color} {output}";

        await ExecuteAsync(command, arguments, false);
        await ExecuteAsync("explorer", $"/select,{output}");

        Directory.Delete("Temp", true);

        frames.Clear();
        await RefreshFilesViewAsync();

        SetEnabled(true);
    }

    void SetEnabled(bool enabled)
    {
        Statusbar_Bar.Visible = !enabled;

        Control_FilesView.Enabled = enabled;

        Control_FirstFrameLabel.Enabled = enabled;
        Control_FirstFramePreview.Enabled = enabled;
        Control_FirstFrameIndex.Enabled = enabled;

        Control_LastFrameLabel.Enabled = enabled;
        Control_LastFramePreview.Enabled = enabled;
        Control_LastFrameIndex.Enabled = enabled;

        Control_ImageMagickPathLabel.Enabled = enabled;
        Control_ImageMagickPathLinkLabel.Enabled = enabled;

        Control_DelayLabel.Enabled = enabled;
        Control_DelayField.Enabled = enabled;
        Control_SkipLabel.Enabled = enabled;
        Control_SkipField.Enabled = enabled;
        Control_LoopLabel.Enabled = enabled;
        Control_LoopField.Enabled = enabled;
        Control_ScaleLabel.Enabled = enabled;
        Control_ScaleField.Enabled = enabled;

        Control_TransparencyCheckbox.Enabled = enabled;
        Control_ConvertButton.Enabled = enabled && frames.Count > 0;
    }

    static async Task<string> ExecuteAsync(string command, string arguments, bool hidden = true)
    {
        var process = new Process();
        process.StartInfo.FileName = command;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        if (hidden)
        {
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }
        process.Start();
        string output = await process.StandardOutput.ReadToEndAsync();
        await process.WaitForExitAsync();
        return output;
    }

    void Control_DelayField_ValueChanged(object sender, EventArgs e)
    {
        Config.instance.delay = (int) Control_DelayField.Value;
        Config.Save();
    }

    void Control_SkipField_ValueChanged(object sender, EventArgs e)
    {
        Config.instance.skip = (int) Control_SkipField.Value;
        Config.Save();
    }

    void Control_LoopField_ValueChanged(object sender, EventArgs e)
    {
        Config.instance.loop = (int) Control_LoopField.Value;
        Config.Save();
    }

    void Control_TransparencyCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        Config.instance.transparency = Control_TransparencyCheckbox.Checked;
        Config.Save();
    }

    void Control_ScaleField_ValueChanged(object sender, EventArgs e)
    {
        Config.instance.scale = (int) Control_ScaleField.Value;
        Config.Save();
    }

    void Control_FirstFrameIndex_Scroll(object sender, EventArgs e)
    {
        RefreshPreview();
    }

    void Control_LastFrameIndex_Scroll(object sender, EventArgs e)
    {
        RefreshPreview();
    }

    void RefreshPreview()
    {
        Control_LastFrameIndex.Minimum = Control_FirstFrameIndex.Value;
        Control_FirstFrameIndex.Maximum = Control_LastFrameIndex.Value;

        RefreshFramePreview(Control_FirstFrameIndex, Control_FirstFramePreview);
        RefreshFramePreview(Control_LastFrameIndex, Control_LastFramePreview);
    }

    void RefreshFramePreview(TrackBar trackbar, PictureBox preview)
    {
        if (trackbar.Value == -1)
        {
            trackbar.Visible = false;
            preview.Visible = false;
            preview.Image = null;
            return;
        }

        trackbar.Visible = true;
        preview.Visible = true;
        preview.Image = frames[trackbar.Value].bitmap;
    }
}