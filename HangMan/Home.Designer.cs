namespace HangMan
{
    partial class Form_Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welcome));
            btn_Start = new Button();
            btn_Start3 = new Button();
            btn_Start4 = new Button();
            btn_Start5 = new Button();
            btn_Start6 = new Button();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.FlatStyle = FlatStyle.Popup;
            btn_Start.Location = new Point(229, 52);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(94, 29);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "Hangman";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Start3
            // 
            btn_Start3.FlatStyle = FlatStyle.Popup;
            btn_Start3.Location = new Point(151, 130);
            btn_Start3.Name = "btn_Start3";
            btn_Start3.Size = new Size(230, 29);
            btn_Start3.TabIndex = 1;
            btn_Start3.Text = "Sliding Puzzle 3x3";
            btn_Start3.UseVisualStyleBackColor = true;
            btn_Start3.Click += btn_Start3_Click;
            // 
            // btn_Start4
            // 
            btn_Start4.FlatStyle = FlatStyle.Popup;
            btn_Start4.Location = new Point(151, 165);
            btn_Start4.Name = "btn_Start4";
            btn_Start4.Size = new Size(230, 29);
            btn_Start4.TabIndex = 2;
            btn_Start4.Text = "Sliding Puzzle 4x4";
            btn_Start4.UseVisualStyleBackColor = true;
            btn_Start4.Click += btn_Start4_Click;
            // 
            // btn_Start5
            // 
            btn_Start5.FlatStyle = FlatStyle.Popup;
            btn_Start5.Location = new Point(151, 200);
            btn_Start5.Name = "btn_Start5";
            btn_Start5.Size = new Size(230, 29);
            btn_Start5.TabIndex = 3;
            btn_Start5.Text = "Sliding Puzzle 5x5";
            btn_Start5.UseVisualStyleBackColor = true;
            btn_Start5.Click += btn_Start5_Click;
            // 
            // btn_Start6
            // 
            btn_Start6.FlatStyle = FlatStyle.Popup;
            btn_Start6.Location = new Point(151, 235);
            btn_Start6.Name = "btn_Start6";
            btn_Start6.Size = new Size(230, 29);
            btn_Start6.TabIndex = 4;
            btn_Start6.Text = "Sliding Puzzle 6x6";
            btn_Start6.UseVisualStyleBackColor = true;
            btn_Start6.Click += btn_Start6_Click;
            // 
            // Form_Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 300);
            Controls.Add(btn_Start6);
            Controls.Add(btn_Start5);
            Controls.Add(btn_Start4);
            Controls.Add(btn_Start3);
            Controls.Add(btn_Start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form_Welcome";
            Text = "Hangman Game - Welcome Screen";
            Load += Form_Welcome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Start;
        private Button btn_Start3;
        private Button btn_Start4;
        private Button btn_Start5;
        private Button btn_Start6;
    }
}
