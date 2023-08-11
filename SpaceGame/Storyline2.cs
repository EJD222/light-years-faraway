using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Storyline2 : Form
    {
        public Storyline2()
        {
            InitializeComponent();
        }

        private void nextStoryline2_Click(object sender, EventArgs e)
        {
            nextStoryline2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            LostInSpaceGame findTheItemsGameForm = new LostInSpaceGame();
            findTheItemsGameForm.Show();
            this.Hide();
        }

        private void nextStoryline2_MouseEnter(object sender, EventArgs e)
        {
            nextStoryline2.Image = Properties.Resources.PlayHover;
        }

        private void nextStoryline2_MouseLeave(object sender, EventArgs e)
        {
            nextStoryline2.Image = Properties.Resources.PlayButton;
        }
    }
}
