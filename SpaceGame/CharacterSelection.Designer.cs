namespace SpaceGame
{
    partial class CharacterSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelection));
            this.selectMinx = new System.Windows.Forms.PictureBox();
            this.selectIre = new System.Windows.Forms.PictureBox();
            this.selectXenon = new System.Windows.Forms.PictureBox();
            this.selectPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectMinx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectIre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectXenon)).BeginInit();
            this.SuspendLayout();
            // 
            // selectMinx
            // 
            this.selectMinx.BackColor = System.Drawing.Color.Transparent;
            this.selectMinx.Location = new System.Drawing.Point(40, 196);
            this.selectMinx.Name = "selectMinx";
            this.selectMinx.Size = new System.Drawing.Size(149, 198);
            this.selectMinx.TabIndex = 1;
            this.selectMinx.TabStop = false;
            this.selectMinx.Click += new System.EventHandler(this.selectMinx_Click);
            // 
            // selectIre
            // 
            this.selectIre.BackColor = System.Drawing.Color.Transparent;
            this.selectIre.Location = new System.Drawing.Point(228, 196);
            this.selectIre.Name = "selectIre";
            this.selectIre.Size = new System.Drawing.Size(149, 198);
            this.selectIre.TabIndex = 2;
            this.selectIre.TabStop = false;
            this.selectIre.Click += new System.EventHandler(this.selectIre_Click);
            // 
            // selectXenon
            // 
            this.selectXenon.BackColor = System.Drawing.Color.Transparent;
            this.selectXenon.Location = new System.Drawing.Point(414, 196);
            this.selectXenon.Name = "selectXenon";
            this.selectXenon.Size = new System.Drawing.Size(149, 198);
            this.selectXenon.TabIndex = 3;
            this.selectXenon.TabStop = false;
            this.selectXenon.Click += new System.EventHandler(this.selectXenon_Click);
            // 
            // selectPlay
            // 
            this.selectPlay.BackColor = System.Drawing.Color.Transparent;
            this.selectPlay.BackgroundImage = global::SpaceGame.Properties.Resources.PlayButton;
            this.selectPlay.FlatAppearance.BorderSize = 0;
            this.selectPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.selectPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPlay.Font = new System.Drawing.Font("Aku & Kamu", 15.75F);
            this.selectPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectPlay.Location = new System.Drawing.Point(223, 582);
            this.selectPlay.Name = "selectPlay";
            this.selectPlay.Size = new System.Drawing.Size(151, 66);
            this.selectPlay.TabIndex = 4;
            this.selectPlay.TabStop = false;
            this.selectPlay.UseVisualStyleBackColor = false;
            this.selectPlay.Click += new System.EventHandler(this.selectPlay_Click);
            this.selectPlay.MouseEnter += new System.EventHandler(this.selectPlay_MouseEnter);
            this.selectPlay.MouseLeave += new System.EventHandler(this.selectPlay_MouseLeave);
            // 
            // CharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.CharacterSelection;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 671);
            this.Controls.Add(this.selectPlay);
            this.Controls.Add(this.selectXenon);
            this.Controls.Add(this.selectIre);
            this.Controls.Add(this.selectMinx);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light-Years Faraway";
            ((System.ComponentModel.ISupportInitialize)(this.selectMinx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectIre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectXenon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox selectMinx;
        private System.Windows.Forms.PictureBox selectIre;
        private System.Windows.Forms.PictureBox selectXenon;
        private System.Windows.Forms.Button selectPlay;
    }
}