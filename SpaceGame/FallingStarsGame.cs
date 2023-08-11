using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SpaceGame
{

    public partial class FallingStarsGame : Form
    {
        int characterSelection = 0;
        bool goingLeft, goingRight;
        int speed = 4;
        int score = 0;
        int missed = 0;

        public static int highScore;

        Random randomX = new Random(); //Random Generator for X Value
        Random randomY = new Random(); //Random Generator for Y Value

        PictureBox missedItem = new PictureBox(); //Container if the Player did not Catch the Item

        public FallingStarsGame(int choice)
        {
            InitializeComponent();
            characterSelection = choice;
            GameTimer.Stop();
            MainGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "" + score;
            txtMiss.Text = "" + missed;
            txtMiss.Visible = false;
            PlayerMovement();
            ItemsFallingAndCatching();
            LifeCountdown();
            GameLevels();
            LoseGame();
            ReadingHighScore();
            WritingHighScore();
            PlayerMovementWhenMissed();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goingRight = true;
            }
            DoubleBuffered = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goingLeft = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                goingRight = false;
            }
            DoubleBuffered = true;
        }

        private void DropAndCatch_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            CharacterSkin();
        }

        private void CharacterSkin()
        {
            if (characterSelection == 1)
            {
                Player.Location = new Point(239, 564);
                Player.Image = SpaceGame.Properties.Resources.MinxR;
                Player.Width = 109;
                Player.Height = 103;
            }
            else if (characterSelection == 2)
            {
                Player.Location = new Point(254, 559);
                Player.Image = SpaceGame.Properties.Resources.IreR;
                Player.Width = 87;
                Player.Height = 110;
            }
            else if (characterSelection == 3)
            {
                Player.Location = new Point(253, 559);
                Player.Image = SpaceGame.Properties.Resources.XenonR;
                Player.Width = 89;
                Player.Height = 110;
            }
        }

        private void CharacterSkinMovementR()
        {
            if (characterSelection == 1)
            {
                Player.Image = SpaceGame.Properties.Resources.MinxR;
                Player.Width = 109;
                Player.Height = 103;
            }
            else if (characterSelection == 2)
            {
                Player.Image = SpaceGame.Properties.Resources.IreR;
                Player.Width = 87;
                Player.Height = 110;
            }
            else if (characterSelection == 3)
            {
                Player.Image = SpaceGame.Properties.Resources.XenonR;
                Player.Width = 89;
                Player.Height = 110;
            }
        }

        private void CharacterSkinMovementL()
        {
            if (characterSelection == 1)
            {
                Player.Image = SpaceGame.Properties.Resources.MinxL;
                Player.Width = 109;
                Player.Height = 103;
            }
            else if (characterSelection == 2)
            {
                Player.Image = SpaceGame.Properties.Resources.IreL;
                Player.Width = 87;
                Player.Height = 110;
            }
            else if (characterSelection == 3)
            {
                Player.Image = SpaceGame.Properties.Resources.XenonL;
                Player.Width = 89;
                Player.Height = 110;
            }
        }

        private void MainGame()
        {

            CharacterSkin();
            goingLeft = false;
            goingRight = false;
            speed = 4;
            score = 0;
            missed = 0;

            foreach (Control x in Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ItemsToCatch") //Random Position of the Falling Items, if x is a type of picture box AND it has the tag of the Falling Items.
                {
                    x.Top = randomY.Next(80, 300) * -1; //randomY.Next(80, 100) - It generates a Positive Number, then *-1 so that the Falling Items will start out of the Frame then the Timer will bring them down towards the player.

                    x.Left = randomX.Next(5, ClientSize.Width - x.Width); //Border 5 on Left, Border Right - Width of Form minus Width of 1 Falling Item.
                }
            }

            if (MessageBox.Show("Are you ready? Catch all the\nStars!", "Falling Stars", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                GameTimer.Start();
            }
          
        }

        private void PlayerMovement()
        {
            if(goingLeft == true && Player.Left > 0)
            {
                Player.Left -= 12; //Moves the Player 12 pixels to the Left.
                CharacterSkinMovementL();
            }

            if(goingRight == true && Player.Left + Player.Width < ClientSize.Width) //If the goingRight is true and Players' Width and Left is less than form Width meaning the Player is still within the frame of the Game.
            {
                Player.Left += 12; //Moves the Player 12 pixels to the Right.
                CharacterSkinMovementR();
            }

        }

        private void PlayerMovementWhenMissed()
        {
            if (missed == 1)
            {
                Player.Top = 473;
            }

            if (missed == 2)
            {
                Player.Top = 326;
            }

            if (missed == 3)
            {
                Player.Top = 179;
            }

            if (missed == 4)
            {
                Player.Top = 32;
            }
        }

        private void ItemsFallingAndCatching()
        {
            DoubleBuffered = true;
            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ItemsToCatch")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > ClientSize.Height)
                    {
                        missedItem.Image = SpaceGame.Properties.Resources.Blackhole;
                        missedItem.Location = x.Location;
                        missedItem.Width = 60;
                        missedItem.Height = 60;
                        missedItem.BackColor = Color.Transparent;

                        Controls.Add(missedItem);
                        x.Top = randomY.Next(80, 300) * -1;
                        x.Left = randomX.Next(5, ClientSize.Width - x.Width);
                        missed += 1;
                    }

                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        CharacterSkinWhenScored();
                        x.Top = randomY.Next(80, 300) * -1;
                        x.Left = randomX.Next(5, ClientSize.Width - x.Width);
                        score += 1;
                    }
           
                }
            }
        }

        private void CharacterSkinWhenScored()
        {
            if (characterSelection == 1)
            {
                if (Player.Left >= 239)
                {
                    Player.Image = Properties.Resources.MinxRC;
                    Player.Width = 109;
                    Player.Height = 103;
                }

                if (Player.Left < 239)
                {
                    Player.Image = Properties.Resources.MinxLC;
                    Player.Width = 109;
                    Player.Height = 103;
                }
            }
            else if (characterSelection == 2)
            {
                if (Player.Left >= 254)
                {
                    Player.Image = Properties.Resources.IreRC;
                    Player.Width = 87;
                    Player.Height = 110;
                }
                if (Player.Left < 254)
                {
                    Player.Image = Properties.Resources.IreLC;
                    Player.Width = 87;
                    Player.Height = 110;
                }
            }
            else if (characterSelection == 3)
            {
                if (Player.Left >= 253)
                {
                    Player.Image = Properties.Resources.XenonRC;
                    Player.Width = 89;
                    Player.Height = 110;
                }
                if (Player.Left < 253)
                {
                    Player.Image = Properties.Resources.XenonLC;
                    Player.Width = 89;
                    Player.Height = 110;
                }
            }
        }

        private void LifeCountdown()
        {
            if (missed == 1)
            {
                life5.Visible = false;
            }

            if (missed == 2)
            {
                life4.Visible = false;
            }

            if (missed == 3)
            {
                life3.Visible = false;
            }

            if (missed == 4)
            {
                life2.Visible = false;
            }

            if (missed == 5)
            {
                life1.Visible = false;
            }
        }

        private void ReadingHighScore()
        {
            if (!File.Exists("HighScores.txt"))
            {
                //Create A Reader or Create the Text File if it does not exist.
                TextWriter tw = new StreamWriter("HighScores.txt");
                tw.Write("0");
                tw.Close();
            }

            //Opens the Text File and Reads the HighScore.
            TextReader tr = new StreamReader("HighScores.txt");
            highscore.Text = tr.ReadLine();
            tr.Close();
        }

        private void WritingHighScore()
        {
            if(score >= Convert.ToInt32(highscore.Text))
            {
                TextWriter tw = new StreamWriter("HighScores.txt");
                tw.WriteLine(score);
                tw.Close();
            }
        }

        private void GameLevels()
        {

            if (score >= 20)
            {
                levelIndicator.Text = "2";
                speed = 6;
            }

            if (score >= 40)
            {
                levelIndicator.Text = "3";
                speed = 8;
            }

            if (score >= 60)
            {
                levelIndicator.Text = "4";
                speed = 10;
            }

            if (score >= 80)
            {
                levelIndicator.Text = "5";
                speed = 12;
            }

            if (score >= 100)
            {
                levelIndicator.Text = "6";
                speed = 14;
            }

        }

        private void LoseGame()
        {
            if(missed == 5)
            {
                Player.Top = -117;
                GameTimer.Stop();
                if (MessageBox.Show("You Missed a Lot of Stars.\nDo You Want to Play Again?", "Oh No!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CharacterSelection characterSelection = new CharacterSelection();
                    characterSelection.Show();
                    Hide();
                }
                else 
                {
                    MainMenu mainMenuForm = new MainMenu();
                    mainMenuForm.Show();
                    Hide();
                }
            }
        }

    }
}
