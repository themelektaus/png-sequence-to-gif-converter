namespace PngSequenceToGifConverter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Control_FilesView = new System.Windows.Forms.ListView();
            this.Control_ConvertButton = new System.Windows.Forms.Button();
            this.Control_ImageMagickPathLabel = new System.Windows.Forms.Label();
            this.Control_ImageMagickPathLinkLabel = new System.Windows.Forms.LinkLabel();
            this.Dialog_FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.Control_DelayLabel = new System.Windows.Forms.Label();
            this.Control_LoopLabel = new System.Windows.Forms.Label();
            this.Control_DelayField = new System.Windows.Forms.NumericUpDown();
            this.Control_LoopField = new System.Windows.Forms.NumericUpDown();
            this.Control_TransparencyCheckbox = new System.Windows.Forms.CheckBox();
            this.Control_SkipField = new System.Windows.Forms.NumericUpDown();
            this.Control_SkipLabel = new System.Windows.Forms.Label();
            this.Statusbar = new System.Windows.Forms.StatusStrip();
            this.Statusbar_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.Statusbar_Space = new System.Windows.Forms.ToolStripStatusLabel();
            this.Statusbar_Bar = new System.Windows.Forms.ToolStripProgressBar();
            this.Statusbar_Percent = new System.Windows.Forms.ToolStripStatusLabel();
            this.Control_FirstFramePreview = new System.Windows.Forms.PictureBox();
            this.Control_FirstFrameIndex = new System.Windows.Forms.TrackBar();
            this.Control_LastFrameIndex = new System.Windows.Forms.TrackBar();
            this.Control_LastFramePreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Control_LastFrameLabel = new System.Windows.Forms.Label();
            this.Control_FirstFrameLabel = new System.Windows.Forms.Label();
            this.Control_ScaleField = new System.Windows.Forms.NumericUpDown();
            this.Control_ScaleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Control_DelayField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_LoopField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_SkipField)).BeginInit();
            this.Statusbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Control_FirstFramePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_FirstFrameIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_LastFrameIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_LastFramePreview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Control_ScaleField)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_FilesView
            // 
            this.Control_FilesView.AllowDrop = true;
            this.Control_FilesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Control_FilesView.Location = new System.Drawing.Point(12, 12);
            this.Control_FilesView.Name = "Control_FilesView";
            this.Control_FilesView.Size = new System.Drawing.Size(620, 93);
            this.Control_FilesView.TabIndex = 0;
            this.Control_FilesView.TileSize = new System.Drawing.Size(128, 128);
            this.Control_FilesView.UseCompatibleStateImageBehavior = false;
            this.Control_FilesView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_FilesView_DragDrop);
            this.Control_FilesView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_FilesView_DragEnter);
            // 
            // Control_ConvertButton
            // 
            this.Control_ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Control_ConvertButton.Location = new System.Drawing.Point(544, 442);
            this.Control_ConvertButton.Name = "Control_ConvertButton";
            this.Control_ConvertButton.Size = new System.Drawing.Size(88, 25);
            this.Control_ConvertButton.TabIndex = 0;
            this.Control_ConvertButton.Text = "Convert";
            this.Control_ConvertButton.UseVisualStyleBackColor = true;
            this.Control_ConvertButton.Click += new System.EventHandler(this.Control_ConvertButton_Click);
            // 
            // Control_ImageMagickPathLabel
            // 
            this.Control_ImageMagickPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_ImageMagickPathLabel.Location = new System.Drawing.Point(12, 381);
            this.Control_ImageMagickPathLabel.Name = "Control_ImageMagickPathLabel";
            this.Control_ImageMagickPathLabel.Size = new System.Drawing.Size(140, 25);
            this.Control_ImageMagickPathLabel.TabIndex = 4;
            this.Control_ImageMagickPathLabel.Text = "ImageMagick Binaries";
            this.Control_ImageMagickPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Control_ImageMagickPathLinkLabel
            // 
            this.Control_ImageMagickPathLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Control_ImageMagickPathLinkLabel.Location = new System.Drawing.Point(158, 381);
            this.Control_ImageMagickPathLinkLabel.Name = "Control_ImageMagickPathLinkLabel";
            this.Control_ImageMagickPathLinkLabel.Size = new System.Drawing.Size(474, 25);
            this.Control_ImageMagickPathLinkLabel.TabIndex = 5;
            this.Control_ImageMagickPathLinkLabel.TabStop = true;
            this.Control_ImageMagickPathLinkLabel.Text = "ImageMagick";
            this.Control_ImageMagickPathLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dialog_FolderBrowser
            // 
            this.Dialog_FolderBrowser.ShowNewFolderButton = false;
            // 
            // Control_DelayLabel
            // 
            this.Control_DelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_DelayLabel.Location = new System.Drawing.Point(12, 409);
            this.Control_DelayLabel.Name = "Control_DelayLabel";
            this.Control_DelayLabel.Size = new System.Drawing.Size(107, 25);
            this.Control_DelayLabel.TabIndex = 6;
            this.Control_DelayLabel.Text = "Delay";
            this.Control_DelayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Control_LoopLabel
            // 
            this.Control_LoopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_LoopLabel.Location = new System.Drawing.Point(12, 439);
            this.Control_LoopLabel.Name = "Control_LoopLabel";
            this.Control_LoopLabel.Size = new System.Drawing.Size(107, 25);
            this.Control_LoopLabel.TabIndex = 8;
            this.Control_LoopLabel.Text = "Loop";
            this.Control_LoopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Control_DelayField
            // 
            this.Control_DelayField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_DelayField.Location = new System.Drawing.Point(125, 411);
            this.Control_DelayField.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Control_DelayField.Name = "Control_DelayField";
            this.Control_DelayField.Size = new System.Drawing.Size(81, 23);
            this.Control_DelayField.TabIndex = 7;
            this.Control_DelayField.ValueChanged += new System.EventHandler(this.Control_DelayField_ValueChanged);
            // 
            // Control_LoopField
            // 
            this.Control_LoopField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_LoopField.Location = new System.Drawing.Point(125, 442);
            this.Control_LoopField.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Control_LoopField.Name = "Control_LoopField";
            this.Control_LoopField.Size = new System.Drawing.Size(81, 23);
            this.Control_LoopField.TabIndex = 9;
            this.Control_LoopField.ValueChanged += new System.EventHandler(this.Control_LoopField_ValueChanged);
            // 
            // Control_TransparencyCheckbox
            // 
            this.Control_TransparencyCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Control_TransparencyCheckbox.AutoSize = true;
            this.Control_TransparencyCheckbox.Location = new System.Drawing.Point(433, 446);
            this.Control_TransparencyCheckbox.Name = "Control_TransparencyCheckbox";
            this.Control_TransparencyCheckbox.Size = new System.Drawing.Size(95, 19);
            this.Control_TransparencyCheckbox.TabIndex = 14;
            this.Control_TransparencyCheckbox.Text = "Transparency";
            this.Control_TransparencyCheckbox.UseVisualStyleBackColor = true;
            this.Control_TransparencyCheckbox.CheckedChanged += new System.EventHandler(this.Control_TransparencyCheckbox_CheckedChanged);
            // 
            // Control_SkipField
            // 
            this.Control_SkipField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_SkipField.Location = new System.Drawing.Point(282, 411);
            this.Control_SkipField.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Control_SkipField.Name = "Control_SkipField";
            this.Control_SkipField.Size = new System.Drawing.Size(81, 23);
            this.Control_SkipField.TabIndex = 11;
            this.Control_SkipField.ValueChanged += new System.EventHandler(this.Control_SkipField_ValueChanged);
            // 
            // Control_SkipLabel
            // 
            this.Control_SkipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_SkipLabel.Location = new System.Drawing.Point(212, 409);
            this.Control_SkipLabel.Name = "Control_SkipLabel";
            this.Control_SkipLabel.Size = new System.Drawing.Size(64, 25);
            this.Control_SkipLabel.TabIndex = 10;
            this.Control_SkipLabel.Text = "Skip";
            this.Control_SkipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Statusbar
            // 
            this.Statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Statusbar_Info,
            this.Statusbar_Space,
            this.Statusbar_Bar,
            this.Statusbar_Percent});
            this.Statusbar.Location = new System.Drawing.Point(0, 479);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(644, 22);
            this.Statusbar.TabIndex = 1;
            // 
            // Statusbar_Info
            // 
            this.Statusbar_Info.Name = "Statusbar_Info";
            this.Statusbar_Info.Size = new System.Drawing.Size(10, 17);
            this.Statusbar_Info.Text = " ";
            this.Statusbar_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Statusbar_Space
            // 
            this.Statusbar_Space.Name = "Statusbar_Space";
            this.Statusbar_Space.Size = new System.Drawing.Size(579, 17);
            this.Statusbar_Space.Spring = true;
            // 
            // Statusbar_Bar
            // 
            this.Statusbar_Bar.AutoSize = false;
            this.Statusbar_Bar.MarqueeAnimationSpeed = 10;
            this.Statusbar_Bar.Name = "Statusbar_Bar";
            this.Statusbar_Bar.Size = new System.Drawing.Size(100, 16);
            this.Statusbar_Bar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Statusbar_Bar.Visible = false;
            // 
            // Statusbar_Percent
            // 
            this.Statusbar_Percent.AutoSize = false;
            this.Statusbar_Percent.Name = "Statusbar_Percent";
            this.Statusbar_Percent.Size = new System.Drawing.Size(40, 17);
            this.Statusbar_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Control_FirstFramePreview
            // 
            this.Control_FirstFramePreview.Location = new System.Drawing.Point(0, 31);
            this.Control_FirstFramePreview.Margin = new System.Windows.Forms.Padding(0);
            this.Control_FirstFramePreview.Name = "Control_FirstFramePreview";
            this.Control_FirstFramePreview.Size = new System.Drawing.Size(307, 200);
            this.Control_FirstFramePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Control_FirstFramePreview.TabIndex = 12;
            this.Control_FirstFramePreview.TabStop = false;
            // 
            // Control_FirstFrameIndex
            // 
            this.Control_FirstFrameIndex.AutoSize = false;
            this.Control_FirstFrameIndex.LargeChange = 1;
            this.Control_FirstFrameIndex.Location = new System.Drawing.Point(0, 234);
            this.Control_FirstFrameIndex.Margin = new System.Windows.Forms.Padding(0);
            this.Control_FirstFrameIndex.Maximum = 0;
            this.Control_FirstFrameIndex.Minimum = -1;
            this.Control_FirstFrameIndex.Name = "Control_FirstFrameIndex";
            this.Control_FirstFrameIndex.Size = new System.Drawing.Size(307, 26);
            this.Control_FirstFrameIndex.TabIndex = 1;
            this.Control_FirstFrameIndex.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Control_FirstFrameIndex.Value = -1;
            this.Control_FirstFrameIndex.Scroll += new System.EventHandler(this.Control_FirstFrameIndex_Scroll);
            // 
            // Control_LastFrameIndex
            // 
            this.Control_LastFrameIndex.AutoSize = false;
            this.Control_LastFrameIndex.LargeChange = 1;
            this.Control_LastFrameIndex.Location = new System.Drawing.Point(313, 234);
            this.Control_LastFrameIndex.Margin = new System.Windows.Forms.Padding(0);
            this.Control_LastFrameIndex.Maximum = 0;
            this.Control_LastFrameIndex.Minimum = -1;
            this.Control_LastFrameIndex.Name = "Control_LastFrameIndex";
            this.Control_LastFrameIndex.Size = new System.Drawing.Size(307, 26);
            this.Control_LastFrameIndex.TabIndex = 3;
            this.Control_LastFrameIndex.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Control_LastFrameIndex.Value = -1;
            this.Control_LastFrameIndex.Scroll += new System.EventHandler(this.Control_LastFrameIndex_Scroll);
            // 
            // Control_LastFramePreview
            // 
            this.Control_LastFramePreview.Location = new System.Drawing.Point(313, 31);
            this.Control_LastFramePreview.Margin = new System.Windows.Forms.Padding(0);
            this.Control_LastFramePreview.Name = "Control_LastFramePreview";
            this.Control_LastFramePreview.Size = new System.Drawing.Size(307, 200);
            this.Control_LastFramePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Control_LastFramePreview.TabIndex = 14;
            this.Control_LastFramePreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.Control_LastFrameLabel);
            this.panel1.Controls.Add(this.Control_FirstFrameLabel);
            this.panel1.Controls.Add(this.Control_FirstFramePreview);
            this.panel1.Controls.Add(this.Control_LastFrameIndex);
            this.panel1.Controls.Add(this.Control_FirstFrameIndex);
            this.panel1.Controls.Add(this.Control_LastFramePreview);
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 264);
            this.panel1.TabIndex = 3;
            // 
            // Control_LastFrameLabel
            // 
            this.Control_LastFrameLabel.AutoSize = true;
            this.Control_LastFrameLabel.Location = new System.Drawing.Point(313, 11);
            this.Control_LastFrameLabel.Name = "Control_LastFrameLabel";
            this.Control_LastFrameLabel.Size = new System.Drawing.Size(64, 15);
            this.Control_LastFrameLabel.TabIndex = 2;
            this.Control_LastFrameLabel.Text = "Last Frame";
            // 
            // Control_FirstFrameLabel
            // 
            this.Control_FirstFrameLabel.AutoSize = true;
            this.Control_FirstFrameLabel.Location = new System.Drawing.Point(0, 11);
            this.Control_FirstFrameLabel.Name = "Control_FirstFrameLabel";
            this.Control_FirstFrameLabel.Size = new System.Drawing.Size(65, 15);
            this.Control_FirstFrameLabel.TabIndex = 0;
            this.Control_FirstFrameLabel.Text = "First Frame";
            // 
            // Control_ScaleField
            // 
            this.Control_ScaleField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_ScaleField.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Control_ScaleField.Location = new System.Drawing.Point(282, 442);
            this.Control_ScaleField.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.Control_ScaleField.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Control_ScaleField.Name = "Control_ScaleField";
            this.Control_ScaleField.Size = new System.Drawing.Size(81, 23);
            this.Control_ScaleField.TabIndex = 13;
            this.Control_ScaleField.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Control_ScaleField.ValueChanged += new System.EventHandler(this.Control_ScaleField_ValueChanged);
            // 
            // Control_ScaleLabel
            // 
            this.Control_ScaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_ScaleLabel.Location = new System.Drawing.Point(212, 440);
            this.Control_ScaleLabel.Name = "Control_ScaleLabel";
            this.Control_ScaleLabel.Size = new System.Drawing.Size(64, 25);
            this.Control_ScaleLabel.TabIndex = 12;
            this.Control_ScaleLabel.Text = "Scale";
            this.Control_ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 501);
            this.Controls.Add(this.Control_ScaleField);
            this.Controls.Add(this.Control_ScaleLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Statusbar);
            this.Controls.Add(this.Control_SkipField);
            this.Controls.Add(this.Control_SkipLabel);
            this.Controls.Add(this.Control_TransparencyCheckbox);
            this.Controls.Add(this.Control_LoopField);
            this.Controls.Add(this.Control_DelayField);
            this.Controls.Add(this.Control_LoopLabel);
            this.Controls.Add(this.Control_DelayLabel);
            this.Controls.Add(this.Control_ImageMagickPathLinkLabel);
            this.Controls.Add(this.Control_ImageMagickPathLabel);
            this.Controls.Add(this.Control_ConvertButton);
            this.Controls.Add(this.Control_FilesView);
            this.MinimumSize = new System.Drawing.Size(660, 540);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNG Sequence to GIF Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Control_DelayField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_LoopField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_SkipField)).EndInit();
            this.Statusbar.ResumeLayout(false);
            this.Statusbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Control_FirstFramePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_FirstFrameIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_LastFrameIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_LastFramePreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Control_ScaleField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView Control_FilesView;
        private Button Control_ConvertButton;
        private Label Control_ImageMagickPathLabel;
        private LinkLabel Control_ImageMagickPathLinkLabel;
        private FolderBrowserDialog Dialog_FolderBrowser;
        private Label Control_DelayLabel;
        private Label Control_LoopLabel;
        private NumericUpDown Control_DelayField;
        private NumericUpDown Control_LoopField;
        private CheckBox Control_TransparencyCheckbox;
        private NumericUpDown Control_SkipField;
        private Label Control_SkipLabel;
        private StatusStrip Statusbar;
        private ToolStripStatusLabel Statusbar_Info;
        private ToolStripStatusLabel Statusbar_Space;
        private ToolStripProgressBar Statusbar_Bar;
        private ToolStripStatusLabel Statusbar_Percent;
        private PictureBox Control_FirstFramePreview;
        private TrackBar Control_FirstFrameIndex;
        private TrackBar Control_LastFrameIndex;
        private PictureBox Control_LastFramePreview;
        private Panel panel1;
        private Label Control_FirstFrameLabel;
        private NumericUpDown Control_ScaleField;
        private Label Control_ScaleLabel;
        private Label Control_LastFrameLabel;
    }
}