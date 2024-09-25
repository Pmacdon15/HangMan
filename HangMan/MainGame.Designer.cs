namespace HangMan
{
    partial class MainGame
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label_Output_Letters = new Label();
            Lbl_Word = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.main;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(9, 59);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 210);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(207, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(181, 31);
            label2.TabIndex = 13;
            label2.Text = "Letters Guessed";
            // 
            // label_Output_Letters
            // 
            label_Output_Letters.AutoSize = true;
            label_Output_Letters.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label_Output_Letters.Location = new Point(217, 122);
            label_Output_Letters.Margin = new Padding(2, 0, 2, 0);
            label_Output_Letters.Name = "label_Output_Letters";
            label_Output_Letters.Size = new Size(0, 31);
            label_Output_Letters.TabIndex = 14;
            // 
            // Lbl_Word
            // 
            Lbl_Word.AutoSize = true;
            Lbl_Word.Location = new Point(685, 20);
            Lbl_Word.Name = "Lbl_Word";
            Lbl_Word.Size = new Size(50, 20);
            Lbl_Word.TabIndex = 15;
            Lbl_Word.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 20);
            label1.Name = "label1";
            label1.Size = new Size(317, 48);
            label1.TabIndex = 16;
            label1.Text = "Hangman Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 405);
            Controls.Add(label1);
            Controls.Add(Lbl_Word);
            Controls.Add(label_Output_Letters);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "MainGame";
            Text = " ";
            Load += MainGame_Load;
            KeyUp += MainGame_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Label label_Output_Letters;
        private Label Lbl_Word;
        private Label label1;
    }
}