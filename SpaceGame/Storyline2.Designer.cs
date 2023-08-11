namespace SpaceGame
{
    partial class Storyline2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storyline2));
            this.nextStoryline2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextStoryline2
            // 
            this.nextStoryline2.BackColor = System.Drawing.Color.Transparent;
            this.nextStoryline2.BackgroundImage = global::SpaceGame.Properties.Resources.PlayButton;
            this.nextStoryline2.FlatAppearance.BorderSize = 0;
            this.nextStoryline2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextStoryline2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextStoryline2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextStoryline2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextStoryline2.Location = new System.Drawing.Point(339, 477);
            this.nextStoryline2.Name = "nextStoryline2";
            this.nextStoryline2.Size = new System.Drawing.Size(151, 66);
            this.nextStoryline2.TabIndex = 2;
            this.nextStoryline2.TabStop = false;
            this.nextStoryline2.UseVisualStyleBackColor = false;
            this.nextStoryline2.Click += new System.EventHandler(this.nextStoryline2_Click);
            this.nextStoryline2.MouseEnter += new System.EventHandler(this.nextStoryline2_MouseEnter);
            this.nextStoryline2.MouseLeave += new System.EventHandler(this.nextStoryline2_MouseLeave);
            // 
            // Storyline2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.Storyline2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 671);
            this.Controls.Add(this.nextStoryline2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Storyline2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light-Years Faraway";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextStoryline2;
    }
}