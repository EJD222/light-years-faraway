using System;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class BackToEarthPage : Form
    {
        public BackToEarthPage()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            Hide();
        }
    }
}
