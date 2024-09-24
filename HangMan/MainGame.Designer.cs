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
            label_Letter_1 = new Label();
            label_Letter_2 = new Label();
            label_Letter_3 = new Label();
            label_Letter_4 = new Label();
            label_Letter_5 = new Label();
            textBox_Input_Char = new TextBox();
            label1 = new Label();
            button_Check_Letter = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label_Output_Letters = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_Letter_1
            // 
            label_Letter_1.AutoSize = true;
            label_Letter_1.BorderStyle = BorderStyle.FixedSingle;
            label_Letter_1.Location = new Point(60, 136);
            label_Letter_1.Name = "label_Letter_1";
            label_Letter_1.Size = new Size(70, 32);
            label_Letter_1.TabIndex = 0;
            label_Letter_1.Text = "label1";
            // 
            // label_Letter_2
            // 
            label_Letter_2.AutoSize = true;
            label_Letter_2.BorderStyle = BorderStyle.FixedSingle;
            label_Letter_2.Location = new Point(157, 136);
            label_Letter_2.Name = "label_Letter_2";
            label_Letter_2.Size = new Size(70, 32);
            label_Letter_2.TabIndex = 1;
            label_Letter_2.Text = "label2";
            // 
            // label_Letter_3
            // 
            label_Letter_3.AutoSize = true;
            label_Letter_3.BorderStyle = BorderStyle.FixedSingle;
            label_Letter_3.Location = new Point(253, 136);
            label_Letter_3.Name = "label_Letter_3";
            label_Letter_3.Size = new Size(70, 32);
            label_Letter_3.TabIndex = 2;
            label_Letter_3.Text = "label3";
            // 
            // label_Letter_4
            // 
            label_Letter_4.AutoSize = true;
            label_Letter_4.BorderStyle = BorderStyle.FixedSingle;
            label_Letter_4.Location = new Point(336, 136);
            label_Letter_4.Name = "label_Letter_4";
            label_Letter_4.Size = new Size(70, 32);
            label_Letter_4.TabIndex = 3;
            label_Letter_4.Text = "label4";
            // 
            // label_Letter_5
            // 
            label_Letter_5.AutoSize = true;
            label_Letter_5.BorderStyle = BorderStyle.FixedSingle;
            label_Letter_5.Location = new Point(430, 136);
            label_Letter_5.Name = "label_Letter_5";
            label_Letter_5.Size = new Size(70, 32);
            label_Letter_5.TabIndex = 4;
            label_Letter_5.Text = "label5";
            // 
            // textBox_Input_Char
            // 
            textBox_Input_Char.Location = new Point(60, 269);
            textBox_Input_Char.Name = "textBox_Input_Char";
            textBox_Input_Char.Size = new Size(42, 35);
            textBox_Input_Char.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 223);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 6;
            label1.Text = "Input Letter";
            // 
            // button_Check_Letter
            // 
            button_Check_Letter.Location = new Point(108, 269);
            button_Check_Letter.Name = "button_Check_Letter";
            button_Check_Letter.Size = new Size(131, 40);
            button_Check_Letter.TabIndex = 7;
            button_Check_Letter.Text = "Check Letter";
            button_Check_Letter.UseVisualStyleBackColor = true;
            button_Check_Letter.Click += button_Check_Letter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.main;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(585, 126);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 249);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 223);
            label2.Name = "label2";
            label2.Size = new Size(159, 30);
            label2.TabIndex = 13;
            label2.Text = "Letters Guessed";
            // 
            // label_Output_Letters
            // 
            label_Output_Letters.AutoSize = true;
            label_Output_Letters.Location = new Point(352, 269);
            label_Output_Letters.Name = "label_Output_Letters";
            label_Output_Letters.Size = new Size(131, 30);
            label_Output_Letters.TabIndex = 14;
            label_Output_Letters.Text = "a, b, c, d, e, f";
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Output_Letters);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button_Check_Letter);
            Controls.Add(label1);
            Controls.Add(textBox_Input_Char);
            Controls.Add(label_Letter_5);
            Controls.Add(label_Letter_4);
            Controls.Add(label_Letter_3);
            Controls.Add(label_Letter_2);
            Controls.Add(label_Letter_1);
            Name = "MainGame";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Letter_1;
        private Label label_Letter_2;
        private Label label_Letter_3;
        private Label label_Letter_4;
        private Label label_Letter_5;
        private TextBox textBox_Input_Char;
        private Label label1;
        private Button button_Check_Letter;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label_Output_Letters;
    }
}