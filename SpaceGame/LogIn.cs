using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpaceGame
{
    public partial class LogIn : Form
    {
        public static string welcomeUsername1;
        public LogIn()
        {
            InitializeComponent();
            textBoxPassword.AutoSize = false;
            textBoxPassword.Size = new Size(textBoxPassword.Size.Width, 30);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            LoginButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE username = @usn and password = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Checks if the User exists or not
            if (table.Rows.Count > 0)
            {
                welcomeUsername1 = textBoxUsername.Text;
                MainMenu mainMenuForm = new MainMenu();
                mainMenuForm.Show();
                Hide();
            }
            else
            {
                //Checks if the Username Field is empty
                if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Checks if the Password Field is empty
                else if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Checks if the Username or the Password don't exist
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ToRegister_Click(object sender, EventArgs e)
        {
            SignUp signInForm = new SignUp();
            signInForm.Show();
            Hide();
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.Image = Properties.Resources.LogInHover;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.Image = Properties.Resources.LogInButton;
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                textBoxUsername.Text = "username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }
        
    }
}
