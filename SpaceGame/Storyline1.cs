using System;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Storyline1 : Form
    {
        public Storyline1()
        {
            InitializeComponent();
        }

        private void Storyline1_Load(object sender, EventArgs e)
        {
            welcomeUsername.Text = LogIn.welcomeUsername1 + "!";
        }

        private void nextStory2_Click(object sender, EventArgs e)
        {
            Storyline2 storyline2 = new Storyline2();
            storyline2.Show();
            Hide();
        }

        private void nextStoryline2_MouseEnter(object sender, EventArgs e)
        {
            nextStoryline2.Image = Properties.Resources.NextHover;
        }

        private void nextStoryline2_MouseLeave(object sender, EventArgs e)
        {
            nextStoryline2.Image = Properties.Resources.NextButton;
        }
    }
}
