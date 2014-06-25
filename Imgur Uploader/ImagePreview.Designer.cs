namespace Image_Viewer
{
    partial class ImagePreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePreview));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPreviousImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNextImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImageCounter = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPreviousImage,
            this.mnuNextImage,
            this.mnuImageCounter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPreviousImage
            // 
            this.mnuPreviousImage.Name = "mnuPreviousImage";
            this.mnuPreviousImage.Size = new System.Drawing.Size(100, 20);
            this.mnuPreviousImage.Text = "Previous Image";
            this.mnuPreviousImage.Click += new System.EventHandler(this.mnuPreviousImage_Click);
            // 
            // mnuNextImage
            // 
            this.mnuNextImage.Name = "mnuNextImage";
            this.mnuNextImage.Size = new System.Drawing.Size(79, 20);
            this.mnuNextImage.Text = "Next Image";
            this.mnuNextImage.Click += new System.EventHandler(this.mnuNextImage_Click);
            // 
            // mnuImageCounter
            // 
            this.mnuImageCounter.Name = "mnuImageCounter";
            this.mnuImageCounter.Size = new System.Drawing.Size(22, 20);
            this.mnuImageCounter.Text = " ";
            // 
            // ImagePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 149);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImagePreview";
            this.ShowInTaskbar = false;
            this.Text = "Preview Image";
            this.Load += new System.EventHandler(this.ImagePreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPreviousImage;
        private System.Windows.Forms.ToolStripMenuItem mnuNextImage;
        private System.Windows.Forms.ToolStripMenuItem mnuImageCounter;
    }
}

