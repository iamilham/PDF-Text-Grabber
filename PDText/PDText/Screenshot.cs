using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDText
{
    class Screenshot
    {

        public delegate void ScreenshotEventHandler(object sender, ScreenshotEventArgs e);

        public static event ScreenshotEventHandler OnScreenshotTaken;

   


        public Screenshot(int x, int y, int height, int width)
        {
            Rectangle rect = new Rectangle(x, y, height, width);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save("screenshot.jpeg", ImageFormat.Jpeg);
            ScreenshotEventArgs e = new ScreenshotEventArgs(width, height);
            OnScreenshotTaken(this, e);
        }
    }
}
