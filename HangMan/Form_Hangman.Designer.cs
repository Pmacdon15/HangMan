namespace HangMan
{
    partial class Form_Hangman
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
            label1 = new Label();
            btn_PlayAgain = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.main;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(14, 30);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 374);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(327, 203);
            label2.Name = "label2";
            label2.Size = new Size(265, 45);
            label2.TabIndex = 13;
            label2.Text = "Letters Guessed";
            // 
            // label_Output_Letters
            // 
            label_Output_Letters.AutoSize = true;
            label_Output_Letters.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label_Output_Letters.Location = new Point(327, 248);
            label_Output_Letters.Name = "label_Output_Letters";
            label_Output_Letters.Size = new Size(0, 45);
            label_Output_Letters.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(352, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(440, 67);
            label1.TabIndex = 16;
            label1.Text = "Hangman Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_PlayAgain
            // 
            btn_PlayAgain.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_PlayAgain.Location = new Point(818, 160);
            btn_PlayAgain.Margin = new Padding(4);
            btn_PlayAgain.Name = "btn_PlayAgain";
            btn_PlayAgain.Size = new Size(328, 88);
            btn_PlayAgain.TabIndex = 17;
            btn_PlayAgain.Text = "Play Again";
            btn_PlayAgain.UseVisualStyleBackColor = true;
            btn_PlayAgain.Click += btn_PlayAgain_Click;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 608);
            Controls.Add(btn_PlayAgain);
            Controls.Add(label1);
            Controls.Add(label_Output_Letters);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
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
        private Label label1;
        private Button btn_PlayAgain;
    }
}