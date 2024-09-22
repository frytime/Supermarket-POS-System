using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sales_System
{
    public partial class Users : Form
    {
        string salt = Hash.SaltGenerate(16);
      
        
        
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");

        public Users()
        {
            InitializeComponent();
          
        }
       


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                  string hashedPassword = Hash.hashPass(txtPass.Text, salt);

            if (txtPass.Text != "" && txtUser.Text != "" && txtID.Text != "" && int.Parse(txtID.Text) > 0)
            {
                try
                {
                   

                    string insert = "insert into logindb.users(userID, username, password, salt) values('" + int.Parse(txtID.Text) + "','" + txtUser.Text + "','" + hashedPassword + "','" + salt.ToString() + "')";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(insert, conn);


                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted", "Notification");
                    }

                    else
                    {
                        MessageBox.Show("Data Not Inserted", "Notification");
                    }

                }

                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Display();
            

                try
                {


                    string insert = "insert into logindb.employees(IDuser) values('" + int.Parse(txtID.Text) +  "')";
                  
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != "" && txtUser.Text != "" && txtID.Text != "" && int.Parse(txtID.Text) > 0)
                {
                    try
                    {
                        string delete = "delete from logindb.users where userID = " + int.Parse(txtID.Text);
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(delete, conn);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("User Deleted", "Notification");
                        }

                        else
                        {
                            MessageBox.Show("User Not Deleted", "Notification");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error - Employee Must Be Deleted First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Display();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Error - Employee Must Be Deleted First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != "" && txtUser.Text != "" && txtID.Text != "" && int.Parse(txtID.Text) > 0)
                {
                    try
                    {
                        string update = "update logindb.users set username = '" + txtUser.Text + "' ,password = '" + Hash.hashPass(txtPass.Text, salt) + "' where userID = '" + int.Parse(txtID.Text) + "'";


                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(update, conn);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("User Updated", "Notification");
                        }

                        else
                        {
                            MessageBox.Show("User Not Updated", "Notification");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Display();
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

        private void dataGridView_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        public void Display()
        {
            try
            {
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from users";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_users.DataSource = datatbl;
            }
            catch
            {

            }

        }


        private void Users_Load(object sender, EventArgs e)
        {
            conn.Open();
            Display();
            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
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
            txtID.Clear();
        }

        private void dataGridView_users_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_users.Rows[e.RowIndex];
                txtID.Text = current.Cells[0].Value.ToString();
                txtUser.Text = current.Cells[1].Value.ToString();
                txtPass.Text = current.Cells[2].Value.ToString();
                txtSalt.Text = current.Cells[3].Value.ToString();
            }
            catch
            {

            }

        }

        private void dataGridView_users_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text == "Username")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from users where username like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_users.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Password")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from users where password like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_users.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "User ID")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from users where userID like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_users.DataSource = datatbl;
            }

            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            conn.Open();
            Display();
            txtSearch.Clear();
            cmbSearch.SelectedItem = null;
            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnRecommend_Click(object sender, EventArgs e)
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

            txtID.Text = newID.ToString();













        }
    }
}
