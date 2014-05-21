using System.Windows.Forms;
namespace Imgur_Uploader
{
    partial class UploaderFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploaderFrame));
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnCopyLink = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUploadMessage = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.notifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(91, 59);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(105, 38);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(23, 166);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Imgur Link:";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(88, 166);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(106, 13);
            this.lblLink.TabIndex = 2;
            this.lblLink.Text = "NO CURRENT LINK";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Enabled = false;
            this.btnBrowser.Location = new System.Drawing.Point(15, 208);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(105, 23);
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "Open in Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnCopyLink
            // 
            this.btnCopyLink.Enabled = false;
            this.btnCopyLink.Location = new System.Drawing.Point(152, 208);
            this.btnCopyLink.Name = "btnCopyLink";
            this.btnCopyLink.Size = new System.Drawing.Size(108, 23);
            this.btnCopyLink.TabIndex = 4;
            this.btnCopyLink.Text = "Copy Link";
            this.btnCopyLink.UseVisualStyleBackColor = true;
            this.btnCopyLink.Click += new System.EventHandler(this.btnCopyLink_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Imgur Uploader";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShow,
            this.menuUpload,
            this.menuExit});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(113, 70);
            this.notifyIconMenu.Opening += new System.ComponentModel.CancelEventHandler(notifyIconMenu_Opening);
            // 
            // menuShow
            // 
            this.menuShow.Name = "menuShow";
            this.menuShow.Size = new System.Drawing.Size(112, 22);
            this.menuShow.Text = "Show";
            this.menuShow.Click += new System.EventHandler(this.menuShow_Click);
            // 
            // menuUpload
            // 
            this.menuUpload.Name = "menuUpload";
            this.menuUpload.Size = new System.Drawing.Size(112, 22);
            this.menuUpload.Text = "Upload";
            this.menuUpload.Click += new System.EventHandler(this.menuUpload_Click);
            // 
            // menuExit
            // 
            this.menuExit.ImageTransparentColor = System.Drawing.Color.White;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(112, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // lblUploadMessage
            // 
            this.lblUploadMessage.AutoSize = true;
            this.lblUploadMessage.Location = new System.Drawing.Point(44, 100);
            this.lblUploadMessage.Name = "lblUploadMessage";
            this.lblUploadMessage.Size = new System.Drawing.Size(202, 26);
            this.lblUploadMessage.TabIndex = 5;
            this.lblUploadMessage.Text = "Upload and Preview Buttons are disabled\r\nuntil an image is in the Clipboard.";
            this.lblUploadMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(110, 34);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(69, 19);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(79, 140);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(133, 23);
            this.btnCapture.TabIndex = 7;
            this.btnCapture.Text = "Custom Screen Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // UploaderFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblUploadMessage);
            this.Controls.Add(this.btnCopyLink);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UploaderFrame";
            this.Text = "Imgur Uploader";
            this.Activated += new System.EventHandler(this.UploadButtonStatus);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmClose);
            this.Load += new System.EventHandler(this.UploaderFrame_Load);
            this.Resize += new System.EventHandler(this.UploaderFrame_Resize);
            this.notifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnCopyLink;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem menuShow;
        private System.Windows.Forms.ToolStripMenuItem menuUpload;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private Label lblUploadMessage;
        private Button btnPreview;
        private Button btnCapture;
    }
}

