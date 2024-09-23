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

        private void MainGame_Load(object sender, EventArgs e)
        {

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
                    break;
                case 2:
                    // Draw body
                    break;
                case 3:
                    // Draw left arm
                    break;
                case 4:
                    // Draw right arm
                    break;
                case 5:
                    // Draw left leg
                    break;
                case 6:
                    // Draw right leg

                    EndGame(WordToGuess);
                    break;
            }
        }
        private void EndGame(string wordToGuess)
        {
            MessageBox.Show("You have lost the game. The word was " + WordToGuess);
            this.Close();
        }
    }
}
