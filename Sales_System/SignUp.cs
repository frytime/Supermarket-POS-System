using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Sales_System
{
    public partial class SignUp : Form
    {
        string salt = Hash.SaltGenerate(16);

        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult response;

            response = MessageBox.Show("Do you want to go back?", "Notification", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                this.Hide();
            }

            else if (response == DialogResult.No)
            {
                this.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPass.Text;
                bool isPasswordValid = true;

                if (password.Length < 10)
                {
                    isPasswordValid = false;
                    MessageBox.Show("Password must be at least 10 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!password.Any(char.IsUpper))
                {
                    isPasswordValid = false;
                    MessageBox.Show("Password must contain at least one capital letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!password.Any(char.IsDigit))
                {
                    isPasswordValid = false;
                    MessageBox.Show("Password must contain at least one digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!password.Any(ch => !Char.IsLetterOrDigit(ch)))
                {
                    isPasswordValid = false;
                    MessageBox.Show("Password must contain at least one symbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (isPasswordValid)
                {
                    try
                    {

                        List<int> userIDs = new List<int>();
                        conn.Open();

                        string query = "SELECT userID FROM logindb.users";
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    userIDs.Add(reader.GetInt32("userID"));
                                }
                            }
                        }

                        userIDs.Sort();
                        int newID = 1;
                        foreach (int id in userIDs)
                        {
                            if (id == newID)
                            {
                                newID++;
                            }
                            else if (id > newID)
                            {
                                break;
                            }
                        }

                        conn.Close();




                        string hashedPassword = Hash.hashPass(txtPass.Text, salt);

                        if (txtPass.Text != "" && txtUser.Text != "")
                        {
                            try
                            {


                                string insert = "insert into logindb.users(userID, username, password, salt) values('" + newID + "','" + txtUser.Text + "','" + hashedPassword + "','" + salt.ToString() + "')";
                                conn.Open();
                                MySqlCommand cmd = new MySqlCommand(insert, conn);


                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("User Registered", "Notification");
                                }

                                else
                                {
                                    MessageBox.Show("User Not Registered", "Notification");
                                }

                            }

                            catch
                            {
                                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }





                            try
                            {


                                string insert = "insert into logindb.employees(IDuser) values('" + newID + "')";

                                MySqlCommand cmd2 = new MySqlCommand(insert, conn);


                                cmd2.ExecuteNonQuery();

                            }

                            catch
                            {
                                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            conn.Close();

                        }
                        else
                        {
                            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               

            }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
    }

