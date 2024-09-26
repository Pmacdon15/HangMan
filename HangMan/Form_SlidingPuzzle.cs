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
    public partial class Form_SlidingPuzzle : Form
    {

        private int size = 3;
        private List<int> listOfPosition = new List<int>();
        private int indexOfEmptyPosition;
        private List<int> indexOfPossibleMoves;
        private Button moveButton;


        public Form_SlidingPuzzle(int size)
        {
            InitializeComponent();

            this.size = size;

            // create a listOfPositions. Ex: 21 (2 indicates row 2, and 1 indicates col 1)
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    listOfPosition.Add(i * 10 + j);
                }
            }

            // Dispose Buttons

            for (int i = 0; i < listOfPosition.Count - 1; i++)
            {
                Button newButton = new Button();
                newButton.Name = "btn_" + (i + 1).ToString();
                newButton.Text = (i + 1).ToString();
                newButton.Location = new Point(30 + i % size * 100, (i / size) * 100 + 30);
                newButton.Size = new Size(100, 100);
                newButton.Click += new EventHandler(this.MyButtonHandler);
                newButton.Font = new Font("Arial", 24, FontStyle.Bold);
                this.Controls.Add(newButton);
            }

            indexOfEmptyPosition = size * 10 + size;

            Button holeButton = new Button();
            holeButton.Name = "btn_Hole";
            holeButton.Text = "O";
            holeButton.BackColor = Color.Black;
            holeButton.ForeColor = Color.White;
            holeButton.Location = new Point(30 + (size - 1) * 100, (size - 1) * 100 + 30);
            holeButton.Size = new Size(100, 100);
            //holeButton.Click += new EventHandler(this.MyButtonHandler);
            this.Controls.Add(holeButton);
            moveButton = holeButton;



        }

        private bool checkEnd()
        {
            return false;
        }

        private void Form_SlidingPuzzle_Load(object sender, EventArgs e)
        {

            randomPositions();
            //int size = 4;


            // create Buttons
            //for(int i = 0; i < size*size; i++)
            //{
            //    Button newButton = new Button();
            //    newButton.Name = "btn_" + (i+1).ToString();
            //    newButton.Text = (i+1).ToString();
            //    newButton.Location = new Point(30 + i%size * 100, (i / size)*100 + 30);
            //    Console.WriteLine((30 + i * 100).ToString() + "    -    " + (i / size + 30).ToString());
            //    newButton.Size = new Size(100,100);
            //    newButton.Click += new EventHandler(this.MyButtonHandler);

            //    if(i + 1 == 16)
            //    {
            //        newButton.Text = "O";
            //        newButton.BackColor = Color.Black;
            //        newButton.ForeColor = Color.White;
            //    }
            //    this.Controls.Add(newButton);
            //}

        }


        private void randomPositions()
        {

            List<Button> allButtons = [.. this.Controls.OfType<Button>()];
            Random rnd = new Random();


            for (int i = 0; i < 1000*size; i++)
            {
                int r = rnd.Next(allButtons.Count);
                allButtons[r].PerformClick();
            }
        }


        void MyButtonHandler(object sender, EventArgs e)
        {

            bool isPossible = (
                ((Button)sender).Location.X == moveButton.Location.X &&
                    (((Button)sender).Location.Y == moveButton.Location.Y + 100 ||
                    ((Button)sender).Location.Y == moveButton.Location.Y - 100)) ||
            (
                ((Button)sender).Location.Y == moveButton.Location.Y &&
                    (((Button)sender).Location.X == moveButton.Location.X + 100 ||
                    ((Button)sender).Location.X == moveButton.Location.X - 100));


            if (isPossible)
            {

                int tempX = moveButton.Location.X;
                int tempY = moveButton.Location.Y;

                moveButton.Location = new Point(((Button)sender).Location.X, ((Button)sender).Location.Y);
                ((Button)sender).Location = new Point(tempX, tempY);
                //MessageBox.Show("Is Possible");
            }


        }
    }
}