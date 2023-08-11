namespace SpaceGame
{
    partial class Storyline3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storyline3));
            this.nextCharacterSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextCharacterSelection
            // 
            this.nextCharacterSelection.BackColor = System.Drawing.Color.Transparent;
            this.nextCharacterSelection.BackgroundImage = global::SpaceGame.Properties.Resources.NextButton;
            this.nextCharacterSelection.FlatAppearance.BorderSize = 0;
            this.nextCharacterSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextCharacterSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextCharacterSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextCharacterSelection.Font = new System.Drawing.Font("Aku & Kamu", 15.75F);
            this.nextCharacterSelection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextCharacterSelection.Location = new System.Drawing.Point(339, 477);
            this.nextCharacterSelection.Name = "nextCharacterSelection";
            this.nextCharacterSelection.Size = new System.Drawing.Size(151, 66);
            this.nextCharacterSelection.TabIndex = 2;
            this.nextCharacterSelection.UseVisualStyleBackColor = false;
            this.nextCharacterSelection.Click += new System.EventHandler(this.nextCharacterSelection_Click);
            this.nextCharacterSelection.MouseEnter += new System.EventHandler(this.nextCharacterSelection_MouseEnter);
            this.nextCharacterSelection.MouseLeave += new System.EventHandler(this.nextCharacterSelection_MouseLeave);
            // 
            // Storyline3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.Storyline3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 671);
            this.Controls.Add(this.nextCharacterSelection);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Storyline3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light-Years Faraway";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextCharacterSelection;
    }
}