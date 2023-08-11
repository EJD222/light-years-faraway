namespace SpaceGame
{
    partial class FallingStarsGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FallingStarsGame));
            this.txtScore = new System.Windows.Forms.Label();
            this.txtMiss = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.ItemCatch3 = new System.Windows.Forms.PictureBox();
            this.ItemCatch2 = new System.Windows.Forms.PictureBox();
            this.ItemCatch1 = new System.Windows.Forms.PictureBox();
            this.highscore = new System.Windows.Forms.Label();
            this.levelIndicator = new System.Windows.Forms.Label();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life4 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCatch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCatch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCatch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtScore.Font = new System.Drawing.Font("ROBOTECH GP", 13F);
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(235, 13);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(18, 20);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "0";
            // 
            // txtMiss
            // 
            this.txtMiss.AutoSize = true;
            this.txtMiss.BackColor = System.Drawing.Color.Transparent;
            this.txtMiss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtMiss.Font = new System.Drawing.Font("ROBOTECH GP", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiss.ForeColor = System.Drawing.Color.Transparent;
            this.txtMiss.Location = new System.Drawing.Point(389, 10);
            this.txtMiss.Name = "txtMiss";
            this.txtMiss.Size = new System.Drawing.Size(20, 22);
            this.txtMiss.TabIndex = 5;
            this.txtMiss.Text = "0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::SpaceGame.Properties.Resources.MinxL;
            this.Player.Location = new System.Drawing.Point(239, 564);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(109, 103);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // ItemCatch3
            // 
            this.ItemCatch3.BackColor = System.Drawing.Color.Transparent;
            this.ItemCatch3.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemCatch3.Image = ((System.Drawing.Image)(resources.GetObject("ItemCatch3.Image")));
            this.ItemCatch3.Location = new System.Drawing.Point(458, 117);
            this.ItemCatch3.Name = "ItemCatch3";
            this.ItemCatch3.Size = new System.Drawing.Size(57, 60);
            this.ItemCatch3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ItemCatch3.TabIndex = 2;
            this.ItemCatch3.TabStop = false;
            this.ItemCatch3.Tag = "ItemsToCatch";
            // 
            // ItemCatch2
            // 
            this.ItemCatch2.BackColor = System.Drawing.Color.Transparent;
            this.ItemCatch2.Image = ((System.Drawing.Image)(resources.GetObject("ItemCatch2.Image")));
            this.ItemCatch2.Location = new System.Drawing.Point(269, 117);
            this.ItemCatch2.Name = "ItemCatch2";
            this.ItemCatch2.Size = new System.Drawing.Size(57, 60);
            this.ItemCatch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ItemCatch2.TabIndex = 1;
            this.ItemCatch2.TabStop = false;
            this.ItemCatch2.Tag = "ItemsToCatch";
            // 
            // ItemCatch1
            // 
            this.ItemCatch1.BackColor = System.Drawing.Color.Transparent;
            this.ItemCatch1.Image = global::SpaceGame.Properties.Resources.Stars3;
            this.ItemCatch1.Location = new System.Drawing.Point(100, 117);
            this.ItemCatch1.Name = "ItemCatch1";
            this.ItemCatch1.Size = new System.Drawing.Size(57, 60);
            this.ItemCatch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemCatch1.TabIndex = 0;
            this.ItemCatch1.TabStop = false;
            this.ItemCatch1.Tag = "ItemsToCatch";
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.BackColor = System.Drawing.Color.Transparent;
            this.highscore.Font = new System.Drawing.Font("ROBOTECH GP", 13F);
            this.highscore.ForeColor = System.Drawing.Color.White;
            this.highscore.Location = new System.Drawing.Point(96, 13);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(18, 20);
            this.highscore.TabIndex = 6;
            this.highscore.Text = "0";
            // 
            // levelIndicator
            // 
            this.levelIndicator.AutoSize = true;
            this.levelIndicator.BackColor = System.Drawing.Color.Transparent;
            this.levelIndicator.Font = new System.Drawing.Font("ROBOTECH GP", 13F);
            this.levelIndicator.ForeColor = System.Drawing.Color.White;
            this.levelIndicator.Location = new System.Drawing.Point(555, 13);
            this.levelIndicator.Name = "levelIndicator";
            this.levelIndicator.Size = new System.Drawing.Size(15, 20);
            this.levelIndicator.TabIndex = 7;
            this.levelIndicator.Text = "1";
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.Image = global::SpaceGame.Properties.Resources.EarthLife;
            this.life1.Location = new System.Drawing.Point(390, 16);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(14, 14);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 8;
            this.life1.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.Image = global::SpaceGame.Properties.Resources.EarthLife;
            this.life2.Location = new System.Drawing.Point(408, 16);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(14, 14);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 9;
            this.life2.TabStop = false;
            // 
            // life4
            // 
            this.life4.BackColor = System.Drawing.Color.Transparent;
            this.life4.Image = global::SpaceGame.Properties.Resources.EarthLife;
            this.life4.Location = new System.Drawing.Point(444, 16);
            this.life4.Name = "life4";
            this.life4.Size = new System.Drawing.Size(14, 14);
            this.life4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life4.TabIndex = 11;
            this.life4.TabStop = false;
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.Image = global::SpaceGame.Properties.Resources.EarthLife;
            this.life3.Location = new System.Drawing.Point(426, 16);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(14, 14);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 10;
            this.life3.TabStop = false;
            // 
            // life5
            // 
            this.life5.BackColor = System.Drawing.Color.Transparent;
            this.life5.Image = global::SpaceGame.Properties.Resources.EarthLife;
            this.life5.Location = new System.Drawing.Point(462, 16);
            this.life5.Name = "life5";
            this.life5.Size = new System.Drawing.Size(14, 14);
            this.life5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life5.TabIndex = 12;
            this.life5.TabStop = false;
            // 
            // FallingStarsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.DropAndCatchGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 667);
            this.Controls.Add(this.life5);
            this.Controls.Add(this.life4);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.levelIndicator);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.txtMiss);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ItemCatch3);
            this.Controls.Add(this.ItemCatch2);
            this.Controls.Add(this.ItemCatch1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FallingStarsGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light-Years Faraway";
            this.Load += new System.EventHandler(this.DropAndCatch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCatch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCatch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCatch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ItemCatch1;
        private System.Windows.Forms.PictureBox ItemCatch2;
        private System.Windows.Forms.PictureBox ItemCatch3;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtMiss;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Label levelIndicator;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life4;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life5;
    }
}

