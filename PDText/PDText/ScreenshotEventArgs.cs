using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDText
{
    public class ScreenshotEventArgs : EventArgs
    {


        public ScreenshotEventArgs(int width, int height)
        {
            this.Height = height;
            this.Width = width;
        }

        public int Height { get; private set; }
        public int Width { get; private set; }
    }
}
