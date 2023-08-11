namespace SpaceGame
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCPassword = new System.Windows.Forms.TextBox();
            this.NewAccLogIn = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Aileron", 12F);
            this.textBoxUsername.Location = new System.Drawing.Point(179, 224);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(244, 30);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Aileron", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(179, 283);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(244, 27);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Font = new System.Drawing.Font("Aileron", 12F);
            this.textBoxCPassword.Location = new System.Drawing.Point(179, 341);
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.PasswordChar = '●';
            this.textBoxCPassword.Size = new System.Drawing.Size(244, 27);
            this.textBoxCPassword.TabIndex = 3;
            this.textBoxCPassword.UseSystemPasswordChar = true;
            this.textBoxCPassword.Enter += new System.EventHandler(this.textBoxCPassword_Enter);
            this.textBoxCPassword.Leave += new System.EventHandler(this.textBoxCPassword_Leave);
            // 
            // NewAccLogIn
            // 
            this.NewAccLogIn.BackColor = System.Drawing.Color.Transparent;
            this.NewAccLogIn.FlatAppearance.BorderSize = 0;
            this.NewAccLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewAccLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewAccLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewAccLogIn.Location = new System.Drawing.Point(208, 456);
            this.NewAccLogIn.Name = "NewAccLogIn";
            this.NewAccLogIn.Size = new System.Drawing.Size(184, 23);
            this.NewAccLogIn.TabIndex = 4;
            this.NewAccLogIn.UseVisualStyleBackColor = false;
            this.NewAccLogIn.Click += new System.EventHandler(this.NewAccLogIn_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Aku & Kamu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.SignUpButton.Image = global::SpaceGame.Properties.Resources.SignUpButton;
            this.SignUpButton.Location = new System.Drawing.Point(230, 380);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(136, 70);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            this.SignUpButton.MouseEnter += new System.EventHandler(this.SignUpButton_MouseEnter);
            this.SignUpButton.MouseLeave += new System.EventHandler(this.SignUpButton_MouseLeave);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.SignUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 671);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.NewAccLogIn);
            this.Controls.Add(this.textBoxCPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light-Years Faraway";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxCPassword;
        private System.Windows.Forms.Button NewAccLogIn;
        private System.Windows.Forms.Button SignUpButton;
    }
}