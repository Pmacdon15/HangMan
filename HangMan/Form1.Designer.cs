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
            btn_Start = new Button();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.FlatStyle = FlatStyle.Popup;
            btn_Start.Location = new Point(350, 176);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(94, 29);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Dubai", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(42, 50);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(339, 79);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "Hangman Game";
            // 
            // Form_Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 300);
            Controls.Add(lbl_Title);
            Controls.Add(btn_Start);
            Margin = new Padding(2);
            Name = "Form_Welcome";
            Text = "Hangman Game - Welcome Screen";
            Load += Form_Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Start;
        private Label lbl_Title;
    }
}
