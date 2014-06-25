using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Imgur_Uploader;

namespace Image_Viewer
{
    public partial class ImagePreview : Form
    {
        Image image;
        UploaderFrame main;
        int imageIndex;

        public ImagePreview(UploaderFrame main, Image image)
        {
            this.main = main;
            this.image = image;
            this.imageIndex = 0;
            InitializeComponent();
            ButtonStatusUpdate();
        }

        private void ImagePreview_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void LoadImage()
        {
            this.ClientSize = new System.Drawing.Size(image.Width, image.Height);
            this.pictureBox.Size = new System.Drawing.Size(image.Width, image.Height);
            this.pictureBox.Image = image;
        }

        private void mnuNextImage_Click(object sender, EventArgs e)
        {
            imageIndex++;
            image = main.GetImage(imageIndex);
            LoadImage();
            ButtonStatusUpdate();
        }

        private void mnuPreviousImage_Click(object sender, EventArgs e)
        {
            imageIndex--;
            image = main.GetImage(imageIndex);
            LoadImage();
            ButtonStatusUpdate();
        }

        private void ButtonStatusUpdate()
        {
            mnuPreviousImage.Enabled = imageIndex != 0;
            mnuNextImage.Enabled = imageIndex < main.GetImageAmount() - 1;
            mnuImageCounter.Text = (imageIndex + 1) + " / " + main.GetImageAmount();
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            main.ClearImages();
        }
    }
}
