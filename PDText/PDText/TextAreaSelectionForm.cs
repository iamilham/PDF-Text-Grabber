using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PDText
{
    public partial class TextAreaSelectionForm : Form
    {
        
        public TextAreaSelectionForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; // temporary solution to accessing form controls on another thread

            Rectangle r = new Rectangle();
            foreach (Screen s in Screen.AllScreens)
            {
                if (s != Screen.FromControl(this)) // Blackout only the secondary screens
                    r = Rectangle.Union(r, s.Bounds);
            }
            
            this.Top = r.Top;
            this.Left = r.Left;
            this.Width = r.Width;
            this.Height = r.Height;

            TextSelectionCanvas.Width = this.Width;
            TextSelectionCanvas.Height = this.Height;

            TextSelectionCanvas.Location = new Point(0, 0);
            TextSelectionDragHighlight.Show();
        }


        private bool IsMouseReleased = false; // tracks whether or not the user released the mouse after clicking down

        private int SelectionHighLightCoordLeft = 0; // only left as a global variable because of plans for added features
        private int SelectionHighLightCoordTop = 0; // only left as a global variable because of plans for added features


        private void TextAreaSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void TextSelectionCanvas_Mousedown(object sender, EventArgs e)
        {
           
            // called when the canvas button(taking up the entire screen) is clicked

            Thread UpdateSelectionHighlightThread = new Thread(UpdateScreenshotSelectionHighlight);
            UpdateSelectionHighlightThread.Start();

        }

        private void TextSelectionCanvas_MouseUp(object sender, EventArgs e) // called when mouse is released after being clicked ^
        {
            IsMouseReleased = true;

            if (TextSelectionDragHighlight.Width > 0 & TextSelectionDragHighlight.Height > 0)
            {
            int CursorX = System.Windows.Forms.Cursor.Position.X;
            int CursorY = System.Windows.Forms.Cursor.Position.Y;

            this.Hide();

                Screenshot screenshot = new Screenshot(TextSelectionDragHighlight.Location.X, TextSelectionDragHighlight.Location.Y, TextSelectionDragHighlight.Width, TextSelectionDragHighlight.Height);
            }
        }

        private void UpdateScreenshotSelectionHighlight() // moves the blue highlight image selection box based on mouse movement
        {
            IsMouseReleased = false;

            int HighlightWidth;
            int HighlightHeight;

            SelectionHighLightCoordLeft = System.Windows.Forms.Cursor.Position.X;
            SelectionHighLightCoordTop = System.Windows.Forms.Cursor.Position.Y;

            TextSelectionDragHighlight.Left = SelectionHighLightCoordLeft;
            TextSelectionDragHighlight.Top = SelectionHighLightCoordTop;

            while (IsMouseReleased == false)
            {

                // cursorx/y were reassigned at the end of every if statement to reduce the "jumpyness" of the highlight bar.

                int CursorX = System.Windows.Forms.Cursor.Position.X;
                int CursorY = System.Windows.Forms.Cursor.Position.Y; 

                if(CursorX > SelectionHighLightCoordLeft) // moves the highlight box forward if the mouse position goes out further -> in that direction
                {
                    HighlightWidth = CursorX - SelectionHighLightCoordLeft;
                    TextSelectionDragHighlight.Width = HighlightWidth;
                    CursorX = System.Windows.Forms.Cursor.Position.X; 
                    CursorY = System.Windows.Forms.Cursor.Position.Y;
                }

                else if(CursorX < SelectionHighLightCoordLeft) // supposed to move the highlight box forward if the mouse position goes out further <- backwards
                {
                    HighlightWidth = SelectionHighLightCoordLeft - CursorX;
                    TextSelectionDragHighlight.Left = CursorX;
                    TextSelectionDragHighlight.Width = HighlightWidth;
                    CursorX = System.Windows.Forms.Cursor.Position.X; 
                    CursorY = System.Windows.Forms.Cursor.Position.Y; 
                }


                CursorX = System.Windows.Forms.Cursor.Position.X; 
                CursorY = System.Windows.Forms.Cursor.Position.Y; 

                if (CursorY > SelectionHighLightCoordTop) // moves the heightlight box downward if the mouse position is further down than the highleight box
                {
                    HighlightHeight = CursorY - SelectionHighLightCoordTop;
                    TextSelectionDragHighlight.Height = HighlightHeight;
                    CursorX = System.Windows.Forms.Cursor.Position.X; 
                    CursorY = System.Windows.Forms.Cursor.Position.Y;

                }

                else if (CursorY < SelectionHighLightCoordTop)  // moves the heightlight box upward if the mouse position is further up than the highleight box
                {
                    HighlightHeight = SelectionHighLightCoordTop - CursorY;
                    TextSelectionDragHighlight.Top = CursorY;
                    TextSelectionDragHighlight.Height = HighlightHeight;
                    CursorX = System.Windows.Forms.Cursor.Position.X; 
                    CursorY = System.Windows.Forms.Cursor.Position.Y; // 

                }

            }
        }

    }
}
