namespace Screen_Capture
{
    partial class ScreenCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenCapture));
            this.btnToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToClipboard
            // 
            this.btnToClipboard.Location = new System.Drawing.Point(82, 242);
            this.btnToClipboard.Name = "btnToClipboard";
            this.btnToClipboard.Size = new System.Drawing.Size(116, 20);
            this.btnToClipboard.TabIndex = 0;
            this.btnToClipboard.Text = "Copy To Clipboard";
            this.btnToClipboard.UseVisualStyleBackColor = true;
            this.btnToClipboard.Click += new System.EventHandler(this.btnToClipboard_Click);
            // 
            // ScreenCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnToClipboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ScreenCapture";
            this.Text = "Screen Capture";
            this.Load += new System.EventHandler(this.ScreenCapture_Load);
            this.Resize += new System.EventHandler(this.ScreenCapture_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToClipboard;


    }
}

