using System;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class LostInSpaceGame : Form
    {
        int seconds = 0;
        int itemsFound = 0;
        public LostInSpaceGame()
        {
            InitializeComponent();
            countdownTimer.Stop();
            FindTheItemsMG();

        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            itemsFoundCounter.Text = "" + itemsFound;
            timerCount.Text = seconds--.ToString();

            if (seconds < 0)
            {
                countdownTimer.Stop();
            }

            FoundAll();

            if (itemsFound !=10 && seconds == 0)
            {
                if (MessageBox.Show("You did not Find all the\nItems on Time. Do You Want\nto Play Again?", "Oh No!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    FindTheItemsMG();
                }
                else
                {
                    MainMenu mainMenuForm = new MainMenu();
                    mainMenuForm.Show();
                    Hide();
                }
            }
        }

        private void selectTumbler_Click(object sender, EventArgs e)
        {
            selectTumbler.BorderStyle = BorderStyle.Fixed3D;
            itemsFound +=1;
            checkTumbler.Visible = true;
            selectTumbler.Enabled = false;
        }

        private void selectBinoculars_Click(object sender, EventArgs e)
        {
            selectBinoculars.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkBinoculars.Visible = true;
            selectBinoculars.Enabled = false;
        }

        private void selectFlashlight_Click(object sender, EventArgs e)
        {
            selectFlashlight.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkFlashlight.Visible = true;
            selectFlashlight.Enabled = false;
        }

        private void selectWaterBottle_Click(object sender, EventArgs e)
        {
            selectWaterBottle.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkWaterBottle.Visible = true;
            selectWaterBottle.Enabled = false;
        }

        private void selectMap_Click(object sender, EventArgs e)
        {
            selectMap.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkMap.Visible = true;
            selectMap.Enabled = false;
        }

        private void selectCamera_Click(object sender, EventArgs e)
        {
            selectCamera.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkCamera.Visible = true;
            selectCamera.Enabled = false;
        }

        private void selectSunglasses_Click(object sender, EventArgs e)
        {
            selectSunglasses.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkSunglasses.Visible = true;
            selectSunglasses.Enabled = false;
        }

        private void selectBlueGem1_Click(object sender, EventArgs e)
        {
            selectBlueGem1.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkBlueGem1.Visible = true;
            selectBlueGem1.Enabled = false;
        }

        private void selectBackpack_Click(object sender, EventArgs e)
        {
            selectBackpack.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkBackpack.Visible = true;
            selectBackpack.Enabled = false;
        }

        private void selectBlueGem2_Click(object sender, EventArgs e)
        {
            selectBlueGem2.BorderStyle = BorderStyle.Fixed3D;
            itemsFound += 1;
            checkBlueGem2.Visible = true;
            selectBlueGem2.Enabled = false;
        }

        private void FindTheItemsMG()
        {
            if (MessageBox.Show("Are you ready? Find all the\nItems within the Time.", "Lost In Space", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                countdownTimer.Start();
            }

            itemsFound = 0;
            seconds = 60;
            ResetCheckList();
            countdownTimer.Start();

            selectTumbler.BorderStyle = BorderStyle.None;
            selectTumbler.Enabled = true;

            selectBinoculars.BorderStyle = BorderStyle.None;
            selectBinoculars.Enabled = true;

            selectFlashlight.BorderStyle = BorderStyle.None;
            selectFlashlight.Enabled = true;

            selectWaterBottle.BorderStyle = BorderStyle.None;
            selectWaterBottle.Enabled = true;

            selectMap.BorderStyle = BorderStyle.None;
            selectMap.Enabled = true;

            selectCamera.BorderStyle = BorderStyle.None;
            selectCamera.Enabled = true;

            selectSunglasses.BorderStyle = BorderStyle.None;
            selectSunglasses.Enabled = true;

            selectBlueGem1.BorderStyle = BorderStyle.None;
            selectBlueGem1.Enabled = true;

            selectBackpack.BorderStyle = BorderStyle.None;
            selectBackpack.Enabled = true;

            selectBlueGem2.BorderStyle = BorderStyle.None;
            selectBlueGem2.Enabled = true;
        }

        private void ResetCheckList()
        {
            checkBlueGem1.Visible = false;
            checkBlueGem2.Visible = false;
            checkFlashlight.Visible = false;
            checkBackpack.Visible = false;
            checkSunglasses.Visible = false;
            checkWaterBottle.Visible = false;
            checkTumbler.Visible = false;
            checkCamera.Visible = false;
            checkMap.Visible = false;
            checkBinoculars.Visible = false;
        }

        private void FoundAll()
        {
            if (itemsFound == 10 && seconds > 0)
            {
                countdownTimer.Stop();
                if (MessageBox.Show("You Found All the Items! Do\nYou Want to Play Again [YES] or\nPlay the Next Game [NO]?", "Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)                                                                                        
                {
                    FindTheItemsMG();
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
