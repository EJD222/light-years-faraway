using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class CharacterSelection : Form
    {
        int characterSelection = 0;
        public CharacterSelection()
        {
            InitializeComponent();
        }

        private void selectMinx_Click(object sender, EventArgs e)
        {
            characterSelection = 1;
            CharacterChanged();
        }

        private void selectIre_Click(object sender, EventArgs e)
        {
            characterSelection = 2;
            CharacterChanged();
        }

        private void selectXenon_Click(object sender, EventArgs e)
        {
            characterSelection = 3;
            CharacterChanged();
        }

        private void CharacterChanged()
        {
            if (characterSelection == 1)
            {
                selectMinx.BorderStyle = BorderStyle.Fixed3D;
                selectIre.BorderStyle = BorderStyle.None;
                selectXenon.BorderStyle = BorderStyle.None;
            }
            else if (characterSelection == 2)
            {
                selectMinx.BorderStyle = BorderStyle.None;
                selectIre.BorderStyle = BorderStyle.Fixed3D;
                selectXenon.BorderStyle = BorderStyle.None;
            }
            else if (characterSelection == 3)
            {
                selectMinx.BorderStyle = BorderStyle.None;
                selectIre.BorderStyle = BorderStyle.None;
                selectXenon.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void selectPlay_Click(object sender, EventArgs e)
        {
            selectPlay.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            if (characterSelection == 0)
            {
                MessageBox.Show("Please Seleact A Character.", "No Character Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FallingStarsGame formMain = new FallingStarsGame(characterSelection);
                formMain.Show();
                Hide();
            }
        }

        private void selectPlay_MouseEnter(object sender, EventArgs e)
        {
            selectPlay.Image = Properties.Resources.PlayHover;
        }

        private void selectPlay_MouseLeave(object sender, EventArgs e)
        {
            selectPlay.Image = Properties.Resources.PlayButton;
        }
    }
}
