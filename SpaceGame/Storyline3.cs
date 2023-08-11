using System;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Storyline3 : Form
    {
        public Storyline3()
        {
            InitializeComponent();
        }

        private void nextCharacterSelection_Click(object sender, EventArgs e)
        {
            CharacterSelection characterSelection = new CharacterSelection();
            characterSelection.Show();
            Hide();
        }

        private void nextCharacterSelection_MouseEnter(object sender, EventArgs e)
        {
            nextCharacterSelection.Image = Properties.Resources.NextHover;
        }

        private void nextCharacterSelection_MouseLeave(object sender, EventArgs e)
        {
            nextCharacterSelection.Image = Properties.Resources.NextButton;
        }
    }
}
