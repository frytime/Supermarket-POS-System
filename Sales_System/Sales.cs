using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sales_System
{
    public partial class Sales : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        public Sales()
        {
            InitializeComponent();
        }


        public void Display()
        {
            try
            {
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from customers inner join orders where customers.idcustomers = orders.customerID";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_sales.DataSource = datatbl;
            }
            catch
            {

            }

        }
        private void Sales_Load(object sender, EventArgs e)
        {

            conn.Open();
            Display();
            conn.Close();
        }

        private void dataGridView_sales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            DataGridViewRow current = this.dataGridView_sales.Rows[e.RowIndex];
            txtCustomerID.Text = current.Cells[0].Value.ToString();
            txtCustomerName.Text = current.Cells[1].Value.ToString();
            txtID.Text = current.Cells[2].Value.ToString();
            txtAmount.Text = current.Cells[3].Value.ToString();
            txtDate.Text = current.Cells[4].Value.ToString();
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

            txtCustomerID.Clear();
            txtCustomerName.Clear();
            
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
                dataGridView_sales.DataSource = datatbl;
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
                dataGridView_sales.DataSource = datatbl;
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
                dataGridView_sales.DataSource = datatbl;
            }


           else if (cmbSearch.Text == "Customer Name")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from customers where customerName like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_sales.DataSource = datatbl;
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
                dataGridView_sales.DataSource = datatbl;
            }


            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();





        }
    }
}

