namespace PDText
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ReadTextBox = new System.Windows.Forms.RichTextBox();
            this.SelectPDFTextButton = new System.Windows.Forms.Button();
            this.ScreenshotView = new System.Windows.Forms.PictureBox();
            this.TextProcessingLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadTextBox
            // 
            this.ReadTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReadTextBox.Location = new System.Drawing.Point(-1, 373);
            this.ReadTextBox.Name = "ReadTextBox";
            this.ReadTextBox.Size = new System.Drawing.Size(854, 354);
            this.ReadTextBox.TabIndex = 0;
            this.ReadTextBox.Text = "";
            // 
            // SelectPDFTextButton
            // 
            this.SelectPDFTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPDFTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPDFTextButton.Location = new System.Drawing.Point(8, 58);
            this.SelectPDFTextButton.Name = "SelectPDFTextButton";
            this.SelectPDFTextButton.Size = new System.Drawing.Size(854, 32);
            this.SelectPDFTextButton.TabIndex = 1;
            this.SelectPDFTextButton.Text = "Select PDF Text";
            this.SelectPDFTextButton.UseVisualStyleBackColor = true;
            this.SelectPDFTextButton.Click += new System.EventHandler(this.SelectPDFTextButton_Click);
            // 
            // ScreenshotView
            // 
            this.ScreenshotView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScreenshotView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScreenshotView.Location = new System.Drawing.Point(-1, 96);
            this.ScreenshotView.Name = "ScreenshotView";
            this.ScreenshotView.Size = new System.Drawing.Size(854, 271);
            this.ScreenshotView.TabIndex = 2;
            this.ScreenshotView.TabStop = false;
            // 
            // TextProcessingLabel2
            // 
            this.TextProcessingLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextProcessingLabel2.AutoSize = true;
            this.TextProcessingLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TextProcessingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProcessingLabel2.ForeColor = System.Drawing.Color.Black;
            this.TextProcessingLabel2.Location = new System.Drawing.Point(212, 342);
            this.TextProcessingLabel2.Name = "TextProcessingLabel2";
            this.TextProcessingLabel2.Size = new System.Drawing.Size(30, 26);
            this.TextProcessingLabel2.TabIndex = 3;
            this.TextProcessingLabel2.Tag = "";
            this.TextProcessingLabel2.Text = "   ";
            this.TextProcessingLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 723);
            this.Controls.Add(this.TextProcessingLabel2);
            this.Controls.Add(this.ScreenshotView);
            this.Controls.Add(this.SelectPDFTextButton);
            this.Controls.Add(this.ReadTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PDF To Text";
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReadTextBox;
        private System.Windows.Forms.Button SelectPDFTextButton;
        private System.Windows.Forms.PictureBox ScreenshotView;
        private System.Windows.Forms.Label TextProcessingLabel2;
    }
}

