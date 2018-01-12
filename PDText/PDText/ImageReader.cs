using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
using System.Threading;
using System.Drawing;

namespace PDText
{
      class ImageReader
    {

        public string ImageText { get; set; }
        public EventHandler OnTextFinishedReading;
        public EventHandler OnTextStartedReading;

        public void ReadImageText(Image im)
        {
            var ReadImageThread = new Thread(() => ReadText(im));
            ReadImageThread.Start();

            //Thread ReadImageThread = new Thread(ReadText);

        }



        private void ReadText(Image im)
        {
            OnTextStartedReading(this, new EventArgs());
            var Ocr = new AutoOcr();
            
            var Result = Ocr.Read(im);
            ImageText = Result.Text;
            OnTextFinishedReading(this, new EventArgs());
           
        }
    }
}
