namespace PDText
{
    partial class TextAreaSelectionForm
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
            this.TextSelectionCanvas = new System.Windows.Forms.Button();
            this.TextSelectionDragHighlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextSelectionCanvas
            // 
            this.TextSelectionCanvas.Location = new System.Drawing.Point(-2, 0);
            this.TextSelectionCanvas.Name = "TextSelectionCanvas";
            this.TextSelectionCanvas.Size = new System.Drawing.Size(248, 249);
            this.TextSelectionCanvas.TabIndex = 0;
            this.TextSelectionCanvas.UseVisualStyleBackColor = true;
            this.TextSelectionCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextSelectionCanvas_Mousedown);
            this.TextSelectionCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextSelectionCanvas_MouseUp);
            // 
            // TextSelectionDragHighlight
            // 
            this.TextSelectionDragHighlight.BackColor = System.Drawing.Color.SteelBlue;
            this.TextSelectionDragHighlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextSelectionDragHighlight.Location = new System.Drawing.Point(102, 79);
            this.TextSelectionDragHighlight.Name = "TextSelectionDragHighlight";
            this.TextSelectionDragHighlight.Size = new System.Drawing.Size(0, 0);
            this.TextSelectionDragHighlight.TabIndex = 1;
            this.TextSelectionDragHighlight.UseVisualStyleBackColor = false;
            this.TextSelectionDragHighlight.Visible = false;
            // 
            // TextAreaSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TextSelectionDragHighlight);
            this.Controls.Add(this.TextSelectionCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextAreaSelectionForm";
            this.Opacity = 0.9D;
            this.Text = "TextAreaSelectionForm";
            this.Load += new System.EventHandler(this.TextAreaSelectionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TextSelectionCanvas;
        private System.Windows.Forms.Button TextSelectionDragHighlight;
    }
}