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
            ((System.ComponentModel.ISupportInitialize)(this.Control_DelayField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_LoopField)).BeginInit();
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
            this.Control_FilesView.Size = new System.Drawing.Size(600, 331);
            this.Control_FilesView.TabIndex = 0;
            this.Control_FilesView.TileSize = new System.Drawing.Size(128, 128);
            this.Control_FilesView.UseCompatibleStateImageBehavior = false;
            this.Control_FilesView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_FilesView_DragDrop);
            this.Control_FilesView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_FilesView_DragEnter);
            // 
            // Control_ConvertButton
            // 
            this.Control_ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Control_ConvertButton.Location = new System.Drawing.Point(524, 407);
            this.Control_ConvertButton.Name = "Control_ConvertButton";
            this.Control_ConvertButton.Size = new System.Drawing.Size(88, 25);
            this.Control_ConvertButton.TabIndex = 1;
            this.Control_ConvertButton.Text = "Convert";
            this.Control_ConvertButton.UseVisualStyleBackColor = true;
            this.Control_ConvertButton.Click += new System.EventHandler(this.Control_ConvertButton_Click);
            // 
            // Control_ImageMagickPathLabel
            // 
            this.Control_ImageMagickPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_ImageMagickPathLabel.Location = new System.Drawing.Point(12, 346);
            this.Control_ImageMagickPathLabel.Name = "Control_ImageMagickPathLabel";
            this.Control_ImageMagickPathLabel.Size = new System.Drawing.Size(140, 25);
            this.Control_ImageMagickPathLabel.TabIndex = 2;
            this.Control_ImageMagickPathLabel.Text = "ImageMagick Binaries";
            this.Control_ImageMagickPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Control_ImageMagickPathLinkLabel
            // 
            this.Control_ImageMagickPathLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Control_ImageMagickPathLinkLabel.Location = new System.Drawing.Point(158, 346);
            this.Control_ImageMagickPathLinkLabel.Name = "Control_ImageMagickPathLinkLabel";
            this.Control_ImageMagickPathLinkLabel.Size = new System.Drawing.Size(454, 25);
            this.Control_ImageMagickPathLinkLabel.TabIndex = 3;
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
            this.Control_DelayLabel.Location = new System.Drawing.Point(12, 374);
            this.Control_DelayLabel.Name = "Control_DelayLabel";
            this.Control_DelayLabel.Size = new System.Drawing.Size(140, 25);
            this.Control_DelayLabel.TabIndex = 4;
            this.Control_DelayLabel.Text = "Delay";
            this.Control_DelayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Control_LoopLabel
            // 
            this.Control_LoopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_LoopLabel.Location = new System.Drawing.Point(12, 404);
            this.Control_LoopLabel.Name = "Control_LoopLabel";
            this.Control_LoopLabel.Size = new System.Drawing.Size(140, 25);
            this.Control_LoopLabel.TabIndex = 5;
            this.Control_LoopLabel.Text = "Loop";
            this.Control_LoopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Control_DelayField
            // 
            this.Control_DelayField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_DelayField.Location = new System.Drawing.Point(158, 376);
            this.Control_DelayField.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Control_DelayField.Name = "Control_DelayField";
            this.Control_DelayField.Size = new System.Drawing.Size(81, 23);
            this.Control_DelayField.TabIndex = 6;
            this.Control_DelayField.ValueChanged += new System.EventHandler(this.Control_DelayField_ValueChanged);
            // 
            // Control_LoopField
            // 
            this.Control_LoopField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_LoopField.Location = new System.Drawing.Point(158, 407);
            this.Control_LoopField.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Control_LoopField.Name = "Control_LoopField";
            this.Control_LoopField.Size = new System.Drawing.Size(81, 23);
            this.Control_LoopField.TabIndex = 7;
            this.Control_LoopField.ValueChanged += new System.EventHandler(this.Control_LoopField_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Control_LoopField);
            this.Controls.Add(this.Control_DelayField);
            this.Controls.Add(this.Control_LoopLabel);
            this.Controls.Add(this.Control_DelayLabel);
            this.Controls.Add(this.Control_ImageMagickPathLinkLabel);
            this.Controls.Add(this.Control_ImageMagickPathLabel);
            this.Controls.Add(this.Control_ConvertButton);
            this.Controls.Add(this.Control_FilesView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNG Sequence to GIF Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Control_DelayField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_LoopField)).EndInit();
            this.ResumeLayout(false);

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
    }
}