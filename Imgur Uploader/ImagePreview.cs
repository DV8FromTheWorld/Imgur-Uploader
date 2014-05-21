using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class ImagePreview : Form
    {
        Image image;
        public ImagePreview(Image image)
        {
            this.image = image;
            InitializeComponent();
        }

        private void ImagePreview_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(image.Width, image.Height);
            this.pictureBox.Size = new System.Drawing.Size(image.Width, image.Height);
            this.pictureBox.Image = image;
        }
    }
}
