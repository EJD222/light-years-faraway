using System;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            Hide();
        }

        private void backToMainMenu_MouseEnter(object sender, EventArgs e)
        {
            backToMainMenu.Image = Properties.Resources.MenuHover;
        }

        private void backToMainMenu_MouseLeave(object sender, EventArgs e)
        {
            backToMainMenu.Image = Properties.Resources.MenuHover;
        }
    }
}
