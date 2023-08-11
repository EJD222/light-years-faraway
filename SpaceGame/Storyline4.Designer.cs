namespace SpaceGame
{
    partial class Storyline4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storyline4));
            this.playMazeGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playMazeGame
            // 
            this.playMazeGame.BackColor = System.Drawing.Color.Transparent;
            this.playMazeGame.BackgroundImage = global::SpaceGame.Properties.Resources.PlayButton;
            this.playMazeGame.FlatAppearance.BorderSize = 0;
            this.playMazeGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playMazeGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playMazeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playMazeGame.Font = new System.Drawing.Font("Aku & Kamu", 15.75F);
            this.playMazeGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playMazeGame.Location = new System.Drawing.Point(339, 477);
            this.playMazeGame.Name = "playMazeGame";
            this.playMazeGame.Size = new System.Drawing.Size(151, 66);
            this.playMazeGame.TabIndex = 3;
            this.playMazeGame.UseVisualStyleBackColor = false;
            this.playMazeGame.Click += new System.EventHandler(this.playMazeGame_Click);
            this.playMazeGame.MouseEnter += new System.EventHandler(this.playMazeGame_MouseEnter);
            this.playMazeGame.MouseHover += new System.EventHandler(this.playMazeGame_MouseHover);
            // 
            // Light
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.Storyline4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 671);
            this.Controls.Add(this.playMazeGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Light";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light-Years Faraway";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playMazeGame;
    }
}