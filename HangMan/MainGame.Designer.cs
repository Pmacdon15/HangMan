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
            label1 = new Label();
            btn_PlayAgain = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.main;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(9, 20);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 249);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(218, 121);
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
            label_Output_Letters.Location = new Point(228, 152);
            label_Output_Letters.Margin = new Padding(2, 0, 2, 0);
            label_Output_Letters.Name = "label_Output_Letters";
            label_Output_Letters.Size = new Size(0, 31);
            label_Output_Letters.TabIndex = 14;
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
            // btn_PlayAgain
            // 
            btn_PlayAgain.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_PlayAgain.Location = new Point(545, 107);
            btn_PlayAgain.Name = "btn_PlayAgain";
            btn_PlayAgain.Size = new Size(219, 59);
            btn_PlayAgain.TabIndex = 17;
            btn_PlayAgain.Text = "Play Again";
            btn_PlayAgain.UseVisualStyleBackColor = true;
            btn_PlayAgain.Click += btn_PlayAgain_Click;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 405);
            Controls.Add(btn_PlayAgain);
            Controls.Add(label1);
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
        private Label label1;
        private Button btn_PlayAgain;
    }
}