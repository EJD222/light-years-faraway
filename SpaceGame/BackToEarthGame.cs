using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class BackToEarthGame : Form
    {
        Point startingLocation;
        int countdown = 60;

        public BackToEarthGame()
        {
            InitializeComponent();
            mazeTimer.Stop();
            if (MessageBox.Show("Are you ready? Guide the\nSpaceship back to Earth!", "Back To Earth", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                mazeTimer.Start();
            }
            StartGame();
        }

        private void mazeWall(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {            
            startingLocation = start.Location;
            Cursor.Position = PointToScreen(startingLocation);            
        }

        private void mazeTimer_Tick(object sender, EventArgs e)
        {
            
            mazeCountdown.Text = countdown--.ToString();
            if (countdown < 0)
            {
                mazeTimer.Stop();
                if (MessageBox.Show("You Failed to Reach Earth.\nDo You Want to Play Again?", "Oh No!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    countdown = 60;
                    StartGame();
                    mazeTimer.Start();
                }
                else
                {
                    MainMenu mainMenuForm = new MainMenu();
                    mainMenuForm.Show();
                    this.Hide();
                }
            }
        }

        private void MazeGame_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            Bitmap bm = new Bitmap(new Bitmap(Properties.Resources.Spaceship),45,16);
            outerPanel.Cursor = new Cursor(bm.GetHicon());
            mazeTimer.Start();
        }

        private void earthFinishLine_MouseEnter(object sender, EventArgs e)
        {
            mazeTimer.Stop();
            if (MessageBox.Show("You Guided Us Back Home! Do\nYou Want to Play Again [YES] or\nPlay Another Game [NO]?", "Back To Earth!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                countdown = 60;
                StartGame();
                mazeTimer.Start();
            }
            else
            {
                BackToEarthPage backToEarthForm = new BackToEarthPage();
                backToEarthForm.Show();
                Hide();
            }
        }

    }
}
