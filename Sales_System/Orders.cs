using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Sales_System
{
    public partial class Orders : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        public Orders()
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


        public void Display()
        {
            try
            {
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "SELECT orders.idorders, orders.totalamount, orders.date, products.productsID, products.productName, products.price, orderproductlink.quantity FROM orders INNER JOIN orderproductlink ON orders.idorders = orderproductlink.orderID INNER JOIN products ON orderproductlink.productID = products.productsID";

                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_orders.DataSource = datatbl;
            }
            catch
            {

            }
        }


        private void Orders_Load(object sender, EventArgs e)
        {
            conn.Open();
            Display();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text != "" && txtDate.Text != "" && txtID.Text != "" && int.Parse(txtID.Text) > 0 && Convert.ToDouble(txtAmount.Text) > 0)
                {
                    try
                    {


                        string delete = "delete from logindb.orders where idorders = " + int.Parse(txtID.Text);
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(delete, conn);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Order Deleted", "Notification");
                        }

                        else
                        {
                            MessageBox.Show("Order Not Deleted", "Notification");
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text != "" && txtDate.Text != "" && txtID.Text != "" && int.Parse(txtID.Text) > 0 && Convert.ToDouble(txtAmount.Text) > 0)
                {
                    try
                    {
                        string insert = "insert into logindb.orders(idorders, totalamount, date) values('" + int.Parse(txtID.Text) + "','" + double.Parse(txtAmount.Text) + "','" + txtDate.Text + "')";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(insert, conn);


                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Order Inserted", "Notification");
                        }

                        else
                        {
                            MessageBox.Show("Order Not Inserted", "Notification");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtAmount.Text != "" && txtDate.Text != "" && txtID.Text != "" && int.Parse(txtID.Text) > 0 && Convert.ToDouble(txtAmount.Text) > 0)
                {
                    try
                    {
                        string update = "update logindb.orders set totalamount = '" + double.Parse(txtAmount.Text) + "',date = '" + txtDate.Text + "' where idorders = '" + int.Parse(txtID.Text) + "'";


                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(update, conn);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Order Updated", "Notification");
                        }

                        else
                        {
                            MessageBox.Show("Order Not Updated", "Notification");
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

        private void dataGridView_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_orders.Rows[e.RowIndex];
                txtID.Text = current.Cells[0].Value.ToString();
                txtAmount.Text = current.Cells[1].Value.ToString();
                txtDate.Text = current.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtDate.Clear();
            txtID.Clear();
            txtSearch.Clear();
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
            if (cmbSearch.Text == "Date Ordered")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from orders where date like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_orders.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Total Amount")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from orders where totalamount like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_orders.DataSource = datatbl;
            }


            else if (cmbSearch.Text == "Order ID")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from orders where idorders like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_orders.DataSource = datatbl;
            }

            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            List<int> orderIDs = new List<int>();
            conn.Open();

            string query = "SELECT idorders FROM logindb.orders";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orderIDs.Add(reader.GetInt32("idorders"));
                    }
                }
            }

            orderIDs.Sort();
            int newID = 1;
            foreach (int id in orderIDs)
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
