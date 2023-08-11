using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpaceGame
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            textBoxPassword.AutoSize = false;
            textBoxPassword.Size = new Size(textBoxPassword.Size.Width, 30);
            
            textBoxCPassword.AutoSize = false;
            textBoxCPassword.Size = new Size(textBoxCPassword.Size.Width, 30);

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

        private void textBoxCPassword_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxCPassword.Text;
            if (cpassword.ToLower().Trim().Equals("password"))
            {
                textBoxCPassword.Text = "";
                textBoxCPassword.UseSystemPasswordChar = true;
                textBoxCPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxCPassword_Leave(object sender, EventArgs e)
        {
            
            String cpassword = textBoxCPassword.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                textBoxCPassword.Text = "password";
                textBoxCPassword.UseSystemPasswordChar = false;
                textBoxCPassword.ForeColor = Color.Gray;
            } 
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SignUpButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`username`, `password`) VALUES (@usn, @pass)", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            //Opens the Connection
            db.openConnection();

            //Checks if the Textboxes contain the Default Values 
            if (!checkTextBoxesValues())
            {
                //Checks if the Password is equal to the Confirm Password
                if (textBoxPassword.Text.Equals(textBoxCPassword.Text))
                {
                    //Checks if this Username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists,\nSelect A Different One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                    }
                    else
                    {
                        // Executes the Query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    
                }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Closes the Connection
            db.closeConnection();

        }

        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = textBoxUsername.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            //Checks if this Username already exists in the Database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }   

        }

        public Boolean checkTextBoxesValues()
        {
            String uname = textBoxUsername.Text;
            String pass = textBoxPassword.Text;

            if (uname.Equals("username") || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void NewAccLogIn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            Hide();
        }

        private void SignUpButton_MouseEnter(object sender, EventArgs e)
        {
            SignUpButton.Image = Properties.Resources.SignUpHover;
        }

        private void SignUpButton_MouseLeave(object sender, EventArgs e)
        {
            SignUpButton.Image = Properties.Resources.SignUpButton;
        }
    }
}
