namespace HangMan
{
    public partial class Form_Welcome : Form
    {
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private void Form_Welcome_Load(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Form game = new Form_Hangman();
            game.Show();
        }

        private void btn_Start3_Click(object sender, EventArgs e)
        {
            Form game = new Form_SlidingPuzzle(3);
            game.Show();

        }

        private void btn_Start4_Click(object sender, EventArgs e)
        {
            Form game = new Form_SlidingPuzzle(4);
            game.Show();

        }

        private void btn_Start5_Click(object sender, EventArgs e)
        {
            Form game = new Form_SlidingPuzzle(5);
            game.Show();

        }

        private void btn_Start6_Click(object sender, EventArgs e)
        {
            Form game = new Form_SlidingPuzzle(6);
            game.Show();

        }
    }
}
