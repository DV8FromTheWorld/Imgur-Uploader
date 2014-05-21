using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Screen_Capture
{
    public partial class ScreenCapture : Form
    {
        private Size oldSize;
        public ScreenCapture()
        {
            oldSize = Size;
            InitializeComponent();
        }

        private void ScreenCapture_Load(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ScreenCapture_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            Rectangle rect = new Rectangle(new Point(0, 0), this.Size);
            Region region = new Region(rect);

            rect.Inflate(-1 * (this.Width - 7), -1 * (this.Height - 31));
            region.Exclude(rect);

            this.Region = region;
            moveButton();
            oldSize = Size;
        }

        private void moveButton()
        {
            int yDelta = Size.Height - oldSize.Height;
            btnToClipboard.Location = new Point(
                (Size.Width / 2) - (btnToClipboard.Width / 2),
                btnToClipboard.Location.Y + yDelta);
        }

        private void btnToClipboard_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(Location.X + 7 , Location.Y + 31, Size.Width - 14, Size.Height - 62);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            Clipboard.SetImage(bmp);
        }
    }
}
