using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Storyline4 : Form
    {
        public Storyline4()
        {
            InitializeComponent();
        }

        private void playMazeGame_Click(object sender, EventArgs e)
        {
            //playMazeGame.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            BackToEarthGame mazeGameForm = new BackToEarthGame();
            mazeGameForm.Show();
            Hide();
        }

        private void playMazeGame_MouseEnter(object sender, EventArgs e)
        {
            playMazeGame.Image = Properties.Resources.PlayHover;
        }

        private void playMazeGame_MouseHover(object sender, EventArgs e)
        {
            playMazeGame.Image = Properties.Resources.PlayButton;
        }
    }
}
