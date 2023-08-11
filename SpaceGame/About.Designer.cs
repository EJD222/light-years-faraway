namespace SpaceGame
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.backToMainMenu.BackgroundImage = global::SpaceGame.Properties.Resources.MenuButton;
            this.backToMainMenu.FlatAppearance.BorderSize = 0;
            this.backToMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backToMainMenu.Location = new System.Drawing.Point(339, 477);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(151, 66);
            this.backToMainMenu.TabIndex = 2;
            this.backToMainMenu.UseVisualStyleBackColor = false;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            this.backToMainMenu.MouseEnter += new System.EventHandler(this.backToMainMenu_MouseEnter);
            this.backToMainMenu.MouseLeave += new System.EventHandler(this.backToMainMenu_MouseLeave);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.About;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 671);
            this.Controls.Add(this.backToMainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
    }
}