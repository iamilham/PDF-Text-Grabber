using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;
namespace PDText
{
    public partial class Form1 : MetroForm
    {

        ImageReader ImageRead = new ImageReader();
        bool isTextingBeingRead = false;
        int TimerTracker = 1;

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        
        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            Screenshot.OnScreenshotTaken += new Screenshot.ScreenshotEventHandler(OnScreenshotTaken);
            ImageRead.OnTextStartedReading += new EventHandler(OnTextStartedReading);
            ImageRead.OnTextFinishedReading += new EventHandler(OnTextFinishedReading);

            ScreenshotView.Image = Image.FromFile("background.png");
            this.Shown += Form1_Shown;
           
        }
        
        void Form1_Shown(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => t.Enabled = true));
            this.Invoke(new Action(() => t.Interval = 500));
            this.Invoke(new Action(() => t.Tick += new EventHandler(timer_Tick)));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            System.Environment.Exit(1);
        }

        private void SelectPDFTextButton_Click(object sender, EventArgs e)
        {

            TextAreaSelectionForm TextSelectForm = new TextAreaSelectionForm();
            TextSelectForm.Show();
            this.Hide();

        }

        void OnScreenshotTaken(object sender, ScreenshotEventArgs e) // event called when the screenshot function is called
        {
            this.Show();
            Image im = CreateCopyImage(e.Height, e.Width);
           
            ScreenshotView.Image = (Image)(new Bitmap(im, new Size(854, 300)));
            File.Delete(@"screenshot.jpeg");
            ImageRead.ReadImageText(im);

        }

        private Image CreateCopyImage(int height, int width) // creates a copy of the image to be loaded in the picture box so I don't get errors trying to deal with accessing an image loaded in a control.
        {
            using (Image im = Image.FromFile("screenshot.jpeg"))
            {
                Bitmap bm = new Bitmap(im, new Size(height, width));
                return bm;
            }
        }

        public void OnTextStartedReading(object sender, EventArgs e) // event called as soon as text starts processing
        {
            this.Invoke(new Action(() => SelectPDFTextButton.Enabled = false));
            isTextingBeingRead = true;

            TextProcessingLabel2.Invoke(new Action(() => TextProcessingLabel2.Visible = true));

            this.Invoke(new Action(() => t.Stop()));
            this.Invoke(new Action(() => t.Start()));
        }

        private void OnTextFinishedReading(object Sender, EventArgs e) // event called as soon as text finished processing
        {
            // TextProcessingLabel.Visible = false;
            isTextingBeingRead = false;
            this.Invoke(new Action(() => SelectPDFTextButton.Enabled = true));
            TextProcessingLabel2.Invoke(new Action(() => TextProcessingLabel2.Visible = false));
            ReadTextBox.Invoke(new Action(() => ReadTextBox.Text += ImageRead.ImageText));

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isTextingBeingRead == true)
            {
                if (TimerTracker == 1)
                {

                    TextProcessingLabel2.Text = "Please wait.... the text is being processed⬤";
                    TimerTracker = 2;
                    return;
                }
                 if (TimerTracker == 2)
                {
                    
                    TextProcessingLabel2.Text = "Please wait.... the text is being processed⬤⬤";
                    TimerTracker = 3;
                    return;
                }

                 if (TimerTracker == 3)
                {
                    TextProcessingLabel2.Text = "Please wait.... the text is being processed⬤⬤⬤";
                    TimerTracker = 1;
                    return;
                }

            }
            
        }
    }
}
