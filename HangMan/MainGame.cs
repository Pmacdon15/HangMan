using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class MainGame : Form
    {
        public string WordToGuess = "hello";
        public char[] WordToGuessArray;
        public int NumberOfWrongGuesses = 0;

        public MainGame()
        {
            InitializeComponent();
            WordToGuessArray = WordToGuess.ToCharArray();
            label_Letter_1.Text = "";
            label_Letter_2.Text = "";
            label_Letter_3.Text = "";
            label_Letter_4.Text = "";
            label_Letter_5.Text = "";
            label_Output_Letters.Text = "";

            for (int i = 0; i < WordToGuessArray.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        label_Letter_1.Text = "*";
                        break;
                    case 1:
                        label_Letter_2.Text = "*";
                        break;
                    case 2:
                        label_Letter_3.Text = "*";
                        break;
                    case 3:
                        label_Letter_4.Text = "*";
                        break;
                    case 4:
                        label_Letter_5.Text = "*";
                        break;
                }
            }
        }       

        private void button_Check_Letter_Click(object sender, EventArgs e)
        {
            char guessedLetter = textBox_Input_Char.Text[0];

            if (WordToGuess.Contains(guessedLetter))
            {
                UpdateLetterLabels(guessedLetter);
            }
            else
            {
                WrongGuess();
            }
        }

        private void UpdateLetterLabels(char guessedLetter)
        {
            for (int i = 0; i < WordToGuessArray.Length; i++)
            {
                if (WordToGuessArray[i] == guessedLetter)
                {
                    switch (i)
                    {
                        case 0:
                            label_Letter_1.Text = guessedLetter.ToString();
                            break;
                        case 1:
                            label_Letter_2.Text = guessedLetter.ToString();
                            break;
                        case 2:
                            label_Letter_3.Text = guessedLetter.ToString();
                            break;
                        case 3:
                            label_Letter_4.Text = guessedLetter.ToString();
                            break;
                        case 4:
                            label_Letter_5.Text = guessedLetter.ToString();
                            EndGameWin();
                            break;
                    }
                }
            }
        }

        private void WrongGuess()
        {
            NumberOfWrongGuesses++;
            switch (NumberOfWrongGuesses)
            {
                case 1:
                    // Draw head
                    SetImage(NumberOfWrongGuesses);
                    break;
                case 2:
                    // Draw body
                    SetImage(NumberOfWrongGuesses);
                    break;
                case 3:
                    // Draw left arm
                    SetImage(NumberOfWrongGuesses);
                    break;
                case 4:
                    // Draw right arm
                    SetImage(NumberOfWrongGuesses);
                    break;
                case 5:
                    // Draw left leg
                    SetImage(NumberOfWrongGuesses);
                    break;
                case 6:
                    // Draw right leg
                    SetImage(NumberOfWrongGuesses);
                    EndGameLose(WordToGuess);
                    break;
            }
        }
        private void EndGameLose(string wordToGuess)
        {
            MessageBox.Show("You have lost the game. The word was " + WordToGuess);
            this.Close();
        }
        private void EndGameWin()
        {
            MessageBox.Show("You have won the game!");
            this.Close();
        }
        private void SetImage(int numberOfWrongGuesses)
        {
            switch (numberOfWrongGuesses)
            {
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

    }
}
