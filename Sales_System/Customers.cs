using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sales_System
{

    public partial class Customers : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        public Customers()
        {
            InitializeComponent();
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

        private void Customers_Load(object sender, EventArgs e)
        {
            conn.Open();
            Display();
            conn.Close();
        }


        public void Display()
        {
            try
            {
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from customers";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_customers.DataSource = datatbl;
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != "" && txtCustomerName.Text != "")
            {
                try
                {
                    string delete = "delete from logindb.customers where idcustomers = " + int.Parse(txtCustomerID.Text);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(delete, conn);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Customer Deleted", "Notification");
                    }

                    else
                    {
                        MessageBox.Show("Customer Not Deleted", "Notification");
                    }
                }
                catch
                {
                    MessageBox.Show("Error - Order Must Be Deleted First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Display();
                conn.Close();
            }

            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click_1(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text != "" && txtCustomerName.Text != "")
                {
                    try
                    {
                        string update = "update logindb.users set customerName = '" + txtCustomerName.Text + "' where idcustomers = '" + int.Parse(txtCustomerID.Text) + "'";


                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(update, conn);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Customer Updated", "Notification");
                        }

                        else
                        {
                            MessageBox.Show("Customer Not Updated", "Notification");
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

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text != "" && txtCustomerName.Text != "" && int.Parse(txtCustomerID.Text) > 0)
                {
                    try
                    {
                        string insert = "insert into logindb.customers(idcustomers, customerName) values('" + int.Parse(txtCustomerID.Text) + "','" + txtCustomerName.Text + "')";
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
                    conn.Close();

                    try
                    {
                        string insert = "insert into logindb.orders(customerID) values('" + int.Parse(txtCustomerID.Text) + "')";
                        conn.Open();
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

        private void dataGridView_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_customers.Rows[e.RowIndex];
                txtCustomerID.Text = current.Cells[0].Value.ToString();
                txtCustomerName.Text = current.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            conn.Open();
            Display();
            txtSearch.Clear();
            cmbSearch.SelectedItem = null;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text == "Customer Name")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from customers where customerName like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_customers.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Customer ID")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from customers where idcustomers like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_customers.DataSource = datatbl;
            }

            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        private void btn_Recommend_Click(object sender, EventArgs e)
        {
            List<int> customerIDs = new List<int>();
            conn.Open();

            string query = "SELECT idcustomers FROM logindb.customers";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customerIDs.Add(reader.GetInt32("idcustomers"));
                    }
                }
            }

            customerIDs.Sort();
            int newID = 1;
            foreach (int id in customerIDs)
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

            txtCustomerID.Text = newID.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
        }
    }
}
