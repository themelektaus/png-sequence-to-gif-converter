namespace PngSequenceToGifConverter;

public partial class MainForm : Form
{
    readonly string orignalText;
    readonly List<string> files = new();

    public MainForm()
    {
        InitializeComponent();
        orignalText = Text;
    }

    async void MainForm_Load(object sender, EventArgs e)
    {
        SetEnabled(false);

        var path = Config.instance.imageMagickPath;
        Control_ImageMagickPathLinkLabel.Text = Path.GetFullPath(path);
        Control_ImageMagickPathLinkLabel.Click += Control_ImageMagickPathLinkLabel_Click;

        Control_DelayField.Value = Config.instance.delay;
        Control_LoopField.Value = Config.instance.loop;

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
        Control_FilesView.Items.Clear();

        if (Control_FilesView.LargeImageList is not null)
        {
            foreach (Image image in Control_FilesView.LargeImageList.Images)
                image.Dispose();
            Control_FilesView.LargeImageList.Dispose();
        }

        var imageList = new ImageList { ImageSize = new(64, 64) };
        Control_FilesView.LargeImageList = imageList;

        if (files.Count == 0)
        {
            Control_FilesView.Items.Add("Drop files or folders here");
            return;
        }

        var bitmaps = new List<Bitmap>();
        foreach (var file in files)
        {
            await Task.Run(() =>
            {
                var bitmap = new Bitmap(file);
                bitmaps.Add(bitmap);
            });
        }

        if (bitmaps[0].Width < bitmaps[0].Height)
        {
            var ratio = bitmaps[0].Width / (float) bitmaps[0].Height;
            imageList.ImageSize = new((int) Math.Round(64 * ratio), 64);
        }
        else if (bitmaps[0].Width > bitmaps[0].Height)
        {
            var ratio = bitmaps[0].Height / (float) bitmaps[0].Width;
            imageList.ImageSize = new(64, (int) Math.Round(64 * ratio));
        }

        for (int i = 0; i < files.Count; i++)
        {
            Control_FilesView.Items.Add(new ListViewItem(files[i], i));
            imageList.Images.Add(bitmaps[i]);
        }
    }

    void Control_FilesView_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Link;
    }

    async void Control_FilesView_DragDrop(object sender, DragEventArgs e)
    {
        SetEnabled(false);

        files.Clear();

        foreach (var file in (string[]) e.Data.GetData(DataFormats.FileDrop, false))
        {
            if (File.GetAttributes(file).HasFlag(FileAttributes.Directory))
            {
                files.AddRange(Directory.EnumerateFiles(file, "*.png", SearchOption.TopDirectoryOnly));
                continue;
            }

            if (!file.EndsWith(".png"))
                continue;

            files.Add(file);
        }

        await RefreshFilesViewAsync();

        SetEnabled(true);
    }

    async void Control_ConvertButton_Click(object sender, EventArgs e)
    {
        if (files.Count == 0)
            return;

        Text = orignalText + " (Converting...)";

        SetEnabled(false);

        if (!Directory.Exists("Output"))
            Directory.CreateDirectory("Output");

        if (Directory.Exists("Temp"))
            Directory.Delete("Temp", true);

        Directory.CreateDirectory("Temp");

        int index = 0;
        foreach (var file in files)
            File.Copy(file, $"Temp\\{index++:D6}.png");

        var imageMagickPath = Config.instance.imageMagickPath;

        var command = @$"{imageMagickPath}\magick.exe";
        var arguments = @"Temp\000000.png -format ""%[pixel:u.p{0,0}]\n"" info:";
        var color = await ExecuteAsync(command, arguments);
        color = color.TrimEnd();
        if (!string.IsNullOrEmpty(color))
        {
            var output = $"Output\\{DateTime.Now.Ticks}.gif";
            command = @$"{imageMagickPath}\convert.exe";
            arguments = @$"-delay {Config.instance.delay} -dispose previous Temp\*.png -loop {Config.instance.loop} -transparent {color.Replace(",0)", ",1)")} {output}";
            await ExecuteAsync(command, arguments);
            await ExecuteAsync("explorer", $"/select,{output}");
        }

        Directory.Delete("Temp", true);

        files.Clear();
        await RefreshFilesViewAsync();

        Text = orignalText;

        SetEnabled(true);
    }

    void SetEnabled(bool enabled)
    {
        Control_FilesView.Enabled = enabled;
        Control_ImageMagickPathLabel.Enabled = enabled;
        Control_ImageMagickPathLinkLabel.Enabled = enabled;
        Control_DelayLabel.Enabled = enabled;
        Control_DelayField.Enabled = enabled;
        Control_LoopLabel.Enabled = enabled;
        Control_LoopField.Enabled = enabled;
        Control_ConvertButton.Enabled = enabled && files.Count > 0;
    }

    static async Task<string> ExecuteAsync(string command, string arguments)
    {
        var process = new Process();
        process.StartInfo.FileName = command;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
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

    void Control_LoopField_ValueChanged(object sender, EventArgs e)
    {
        Config.instance.loop = (int) Control_LoopField.Value;
        Config.Save();
    }
}