﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form_Hangman : Form
    {
        public string WordToGuess = "";
        //public char[] WordToGuessArray;
        public int NumberOfWrongGuesses = 0;

        private int RemainingLetters;

        bool IsActive = true;


        public Form_Hangman()
        {
            InitializeComponent();
            
        }
        // function to set game image
        private void SetImage(int numberOfWrongGuesses)
        {
            switch (numberOfWrongGuesses)
            {
                case 0:
                    pictureBox1.Image = HangMan.Properties.Resources.main;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 1:
                    pictureBox1.Image = HangMan.Properties.Resources._1Wrong;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    pictureBox1.Image = HangMan.Properties.Resources._2Wrong;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    pictureBox1.Image = HangMan.Properties.Resources._3Wrong;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    pictureBox1.Image = HangMan.Properties.Resources._4Wrong;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 5:
                    pictureBox1.Image = HangMan.Properties.Resources._5Wrong;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 6:
                    pictureBox1.Image = HangMan.Properties.Resources._6Wrong;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        private void MainGame_Load(object sender, EventArgs e)
        {

            StartGame();
        }

        private void StartGame()
        {
            // Set defauly values
            NumberOfWrongGuesses = 0;
            SetImage(0);
            label_Output_Letters.Text = "";

            btn_PlayAgain.Enabled = false;
            WordClass word = new WordClass();
            WordToGuess = word.getRandomWord();
            RemainingLetters = WordToGuess.Length;

            // Draw letter boxes and cover labels
            for (int i = 0; i < WordToGuess.Length; i++)
            {
                System.Windows.Forms.Label lbl = new();
                lbl.Name = "guessLetter_" + i;
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.White;
                lbl.Text = WordToGuess.ToCharArray()[i].ToString();
                lbl.Size = new Size((int)(this.Width * 0.05), (int)(this.Height * .12));
                lbl.Location = new Point((int)(this.Width * 0.07) * i + (int)(this.Width * 0.03), (int)(this.Height * 0.7));
                lbl.Font = new Font("Arial", 24, FontStyle.Bold);
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                System.Windows.Forms.Label lbl_Cover = new();
                lbl_Cover.BackColor = Color.White;
                lbl_Cover.Size = new Size((int)(this.Width * 0.05), (int)(this.Height * .15));
                lbl_Cover.Location = new Point((int)(this.Width * 0.07) * i + (int)(this.Width * 0.03), (int)(this.Height * 0.7));

                this.Controls.Add(lbl);
                this.Controls.Add(lbl_Cover);
                lbl_Cover.BringToFront();
            }
        }

        private void MainGame_KeyUp(object sender, KeyEventArgs e)
        {
            // Deal with key presses  when games is over
            if (!IsActive) return;

            // Deal with key presses when game is on
            List<System.Windows.Forms.Label> allLabels = [.. this.Controls.OfType<System.Windows.Forms.Label>()];
            if (e.KeyData >= Keys.A && e.KeyData <= Keys.Z)
            {
                // Do nothing is letter has been entered b4
                if (label_Output_Letters.Text.Contains(e.KeyData.ToString()))
                {
                    return;
                }

                if (label_Output_Letters.Text == string.Empty)
                {
                    label_Output_Letters.Text = e.KeyData.ToString();
                }
                else
                {
                    label_Output_Letters.Text += ", " + e.KeyData.ToString();
                }
                // Letter guessed correct
                bool hasLetter = false;
                foreach (var label in allLabels)
                {
                    if (label.Name.Split("_")[0] == "guessLetter" &&
                        label.Text == e.KeyData.ToString())
                    {
                        //MessageBox.Show(label.Text);
                        //MessageBox.Show(e.KeyData.ToString());
                        label.BringToFront();
                        label.ForeColor = Color.LightGreen;
                        RemainingLetters--;
                        hasLetter = true;
                    }
                }
                // Wrong Letter
                if (!hasLetter)
                {
                    NumberOfWrongGuesses++;
                    SetImage(NumberOfWrongGuesses);
                }
                // End of game lose
                if (NumberOfWrongGuesses == 6) EndGame("lose");

                // End of game win
                if (RemainingLetters == 0)
                {
                    EndGame("win");
                }
            }
        }
        // end game function 
        private void EndGame(string status)
        {
            btn_PlayAgain.Enabled = true;
            IsActive = false;

            if (status == "win")
            {
                MessageBox.Show("You Win");
            }
            else if (status == "lose")
            {
                MessageBox.Show("You Lose");

                List<System.Windows.Forms.Label> allLabels = [.. this.Controls.OfType<System.Windows.Forms.Label>()];

                foreach (var label in allLabels)
                {
                    if (label.Name.Split("_")[0] == "guessLetter" &&
                        label.ForeColor == Color.White)
                    {
                        label.ForeColor = Color.LightPink;
                        label.BringToFront();
                    }
                }
            }

        }
        // Play again function
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            // Remove all labels
            List<System.Windows.Forms.Label> allLabels = this.Controls.OfType<System.Windows.Forms.Label>().ToList();

            foreach (var label in allLabels)
            {
                if (label.Name != "label1" && label.Name != "label2" && label.Name != "label_Output_Letters")
                {
                    this.Controls.Remove(label);
                }

            }

            IsActive = true;
            StartGame();
        }
    }
}
