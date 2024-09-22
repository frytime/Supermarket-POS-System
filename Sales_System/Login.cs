using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Sales_System
{
    public partial class Login : Form
    {

        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        public Login()
        {

            InitializeComponent();
        }

        private bool PasswordCheck(string pass, string hash, string salt)
        {
            bool valid = false;

            string hashedvalue = Hash.hashPass(pass, salt);

            if (hashedvalue == hash)
            {
                valid = true;
            }

            return valid;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

           if(user != "" && pass != "")
            {

                try
                {

                    string query = "select salt, password from users where username = '" + txtUser.Text + "'";
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                string passvalue = rdr["password"].ToString();
                                string saltvalue = rdr["salt"].ToString();

                                if (PasswordCheck(txtPass.Text, passvalue, saltvalue) == true)
                                {
                                    if (user == "admin" && pass == "admin")
                                    {
                                        MessageBox.Show("You've logged in successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        MenuForm myMenu = new MenuForm();
                                        myMenu.Show();
                                    }

                                    else
                                    {

                                        MessageBox.Show("You've logged in successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        EmployeeTill myTill = new EmployeeTill();
                                        myTill.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                    }

                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            else
            {
                MessageBox.Show("Login details are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult response;

            response = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (response == DialogResult.No)
            {
                this.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            MenuForm myMenu = new MenuForm();
            myMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm myMenu = new MenuForm();
            myMenu.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SignUp mySignUp = new SignUp();
            mySignUp.Show(); 
        }
    }
}
