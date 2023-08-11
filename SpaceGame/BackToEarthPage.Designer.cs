namespace SpaceGame
{
    partial class BackToEarthPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackToEarthPage));
            this.bmenu_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bmenu_Click
            // 
            this.bmenu_Click.BackColor = System.Drawing.Color.Transparent;
            this.bmenu_Click.FlatAppearance.BorderSize = 0;
            this.bmenu_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bmenu_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bmenu_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmenu_Click.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bmenu_Click.Location = new System.Drawing.Point(535, 640);
            this.bmenu_Click.Name = "bmenu_Click";
            this.bmenu_Click.Size = new System.Drawing.Size(60, 23);
            this.bmenu_Click.TabIndex = 0;
            this.bmenu_Click.UseVisualStyleBackColor = false;
            this.bmenu_Click.Click += new System.EventHandler(this.menu_Click);
            // 
            // BackToEarth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.BackToEarth;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 671);
            this.Controls.Add(this.bmenu_Click);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BackToEarth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light-Years Faraway";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bmenu_Click;
    }
}