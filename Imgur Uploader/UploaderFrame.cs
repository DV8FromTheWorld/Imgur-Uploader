using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Drawing.Imaging;
using Image_Viewer;
using Screen_Capture;

namespace Imgur_Uploader
{

    //Tooltip / bubble for Notify Icon (maybe?)
    //Selection area for screenshot.
    public partial class UploaderFrame : Form
    {
        //CHANGE TO @CLIENT_ID@ and replace with buildscript.
        private const String CLIENT_ID = "efce6070269a7f1";

        //CHANGE TO @CLIENT_SECRET@ and replace with buildscript.
        private const String CLIENT_SECRET = "bc038b940212ad28e0de3eddea1a18375434b143";     

        private BackgroundWorker uploader;
        private BackgroundWorker uploaderAlbum;
        private List<Image> imagesToUpload;
        private String url;

        public UploaderFrame()
        {
            InitializeComponent();
        }

        private void UploaderFrame_Load(object sender, EventArgs e)
        {
            imagesToUpload = new List<Image>();
            uploader = new BackgroundWorker();
            uploader.WorkerSupportsCancellation = true;
            uploader.DoWork += new DoWorkEventHandler(
                delegate(object o, DoWorkEventArgs args)
                {
                    MemoryStream ms = args.Argument as MemoryStream;

                    WebClient w = new WebClient();
                    w.Headers.Add("Authorization", "Client-ID " + CLIENT_ID);


                    NameValueCollection values = new NameValueCollection
                    {
                        { "image", Convert.ToBase64String(ms.ToArray()) }
                    };

                    byte[] response = w.UploadValues("https://api.imgur.com/3/image", values);
                    dynamic result = Encoding.ASCII.GetString(response);
                    System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("link\":\"(.*?)\"");
                    url = reg.Match(result).ToString().Replace("link\":\"", "").Replace("\"", "").Replace("\\/", "/"); 
                });

            uploader.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                delegate(object o, RunWorkerCompletedEventArgs args)
                {
                    lblLink.Text = url;
                    btnUpload.Enabled = true;
                    menuUpload.Enabled = true;
                    btnBrowser.Enabled = true;
                    btnCopyLink.Enabled = true;
                });
        }

        private void UploaderFrame_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && Screen.GetWorkingArea(this).Contains(MousePosition))
            {
                //notifyIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            Process.Start(url);
        }

        private void btnCopyLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(url);
            UploadButtonStatus(sender, e);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowProgram();
        }

        private void menuShow_Click(object sender, EventArgs e)
        {
            ShowProgram();
        }

        private void menuUpload_Click(object sender, EventArgs e)
        {
            Upload();
            ShowProgram();
        }

        private void notifyIconMenu_Opening(object sender, CancelEventArgs e)
        {
            UploadButtonStatus(sender, e);
        }

        private void UploadButtonStatus(object sender, EventArgs e)
        {
            if (ClipboardContainsImage())
            {
                btnUpload.Enabled = true;
                menuUpload.Enabled = true;
                btnPreview.Enabled = true;
                lblUploadMessage.Text = "";
            }
            else
            {
                btnUpload.Enabled = false;
                menuUpload.Enabled = false;
                btnPreview.Enabled = false;
                lblUploadMessage.Text = "Upload and Preview Buttons are disabled \nuntil an image is in the Clipboard.";
            }
        }

        private void ConfirmClose(object sender, FormClosingEventArgs  e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close Imgur Uploader?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ShowProgram()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void Upload()
        {
            lblLink.Text = "Uploading and fetching URL...";
            MemoryStream ms = new MemoryStream();
            loadImages();
            imagesToUpload[0].Save(ms, ImageFormat.Png);
            uploader.RunWorkerAsync(ms);
            btnUpload.Enabled = false;
            menuUpload.Enabled = false;
            btnBrowser.Enabled = false;
            btnCopyLink.Enabled = false;
            imagesToUpload.Clear();
        }
        
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            new ImagePreview(Clipboard.GetImage()).Show();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            new ScreenCapture().Show();
        }
        /// <summary>
        /// Checks to see if there is an image or a collection of images to upload.
        /// </summary>
        /// <returns>true if there are images to upload.</returns>
        private bool ClipboardContainsImage()
        {
            loadImages();
            int count = imagesToUpload.Count;
            imagesToUpload.Clear(); //Clear this to unlock the images (can't delete/rename/move without this).
            return count == 1;
        }

        /// <summary>
        /// Takes all images given and loads them into a List in preparation for upload.
        /// </summary>
        private void loadImages()
        {
            imagesToUpload.Clear();
            if (Clipboard.ContainsImage())
            {
                imagesToUpload.Add(Clipboard.GetImage());
                return;
            }

            IDataObject d = Clipboard.GetDataObject();
            if (d.GetDataPresent(DataFormats.FileDrop))
            {
                string[] copiedFiles = (String[])d.GetData(DataFormats.FileDrop);
                foreach (string filePath in copiedFiles)
                {
                    try
                    {
                        imagesToUpload.Add(Image.FromFile(@filePath));
                    }
                    catch (Exception)
                    {
                        //Do Nothing
                    }
                }
                return;
            }
        }
    }
}
