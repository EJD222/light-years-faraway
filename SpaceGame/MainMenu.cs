using System;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void lostinspacebutton_MouseEnter(object sender, EventArgs e)
        {
            lostinspacebutton.Image = Properties.Resources.LostInSpaceHover;
        }

        private void lostinspacebutton_MouseLeave(object sender, EventArgs e)
        {
            lostinspacebutton.Image = Properties.Resources.LostInSpaceButton;
        }

        private void lostinspacebutton_Click(object sender, EventArgs e)
        {
            Storyline1 storyline1Form = new Storyline1();
            storyline1Form.Show();
            Hide();
        }

        private void fallingstarsbutton_MouseEnter(object sender, EventArgs e)
        {
            fallingstarsbutton.Image = Properties.Resources.FallingStarsHover;
        }

        private void fallingstarsbutton_MouseLeave(object sender, EventArgs e)
        {
            fallingstarsbutton.Image = Properties.Resources.FallingStarsButton;
        }

        private void fallingstarsbutton_Click(object sender, EventArgs e)
        {
            Storyline3 storyline3Form = new Storyline3();
            storyline3Form.Show();
            Hide();
        }

        private void backtoearthbutton_MouseEnter(object sender, EventArgs e)
        {
            backtoearthbutton.Image = Properties.Resources.BackToEarthHover;
        }

        private void backtoearthbutton_MouseLeave(object sender, EventArgs e)
        {
            backtoearthbutton.Image = Properties.Resources.BackToEarthButton;
        }

        private void backtoearthbutton_Click(object sender, EventArgs e)
        {
            Storyline4 storyline4Form = new Storyline4();
            storyline4Form.Show();
            Hide();
        }

        private void aboutbutton_MouseEnter(object sender, EventArgs e)
        {
           aboutbutton.Image = Properties.Resources.AboutHover;
        }

        private void aboutbutton_MouseLeave(object sender, EventArgs e)
        {
            aboutbutton.Image = Properties.Resources.AboutButton;
        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
           Hide();
        }

        private void exitbutton_MouseEnter(object sender, EventArgs e)
        {
            exitbutton.Image = Properties.Resources.ExitHover;
        }

        private void exitbutton_MouseLeave(object sender, EventArgs e)
        {
            exitbutton.Image = Properties.Resources.ExitButton;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
