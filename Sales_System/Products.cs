using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sales_System
{
    public partial class Products : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        public Products()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            txtStock.Clear();
            txtBarcode.Clear();
            lblGenerate.Text = "";
            txtProductID.Clear();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into logindb.products(productsID, productName, price, description, stock, barcode, supplerID) values('" + int.Parse(txtProductID.Text) + "','" + txtProductName.Text + "','" + Convert.ToDecimal(txtPrice.Text) + "','" + txtDescription.Text + "','" + int.Parse(txtStock.Text) + "','" + int.Parse(txtBarcode.Text) + "','" + int.Parse(txtSupplierID.Text) + "')";
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
                if (txtProductID.Text == "" || txtProductName.Text == "" || txtPrice.Text == "" || txtDescription.Text == "" || txtStock.Text == "" || txtBarcode.Text == "")
                {
                    MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Display();
            conn.Close();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update logindb.products set productName = '" + txtProductName.Text + "',price = '" + Convert.ToDecimal(txtPrice.Text) + "',description = '" + txtDescription.Text + "' ,stock = '" + int.Parse(txtStock.Text) + "',barcode = '" + int.Parse(txtBarcode.Text) + "' where productsID = '" + int.Parse(txtProductID.Text) + "'";


                conn.Open();

                MySqlCommand cmd = new MySqlCommand(update, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Product Updated", "Notification");
                }

                else
                {
                    MessageBox.Show("Product Not Updated", "Notification");
                }
            }
            catch
            {
                if (txtProductID.Text == "" || txtProductName.Text == "" || txtPrice.Text == "" || txtDescription.Text == "" || txtStock.Text == "" || txtBarcode.Text == "")
                {
                    MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Display();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from logindb.products where productsID = " + int.Parse(txtProductID.Text);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(delete, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Product Deleted", "Notification");
                }

                else
                {
                    MessageBox.Show("Product Not Deleted", "Notification");
                }
            }
            catch
            {
                if (txtProductID.Text == "" || txtProductName.Text == "" || txtPrice.Text == "" || txtDescription.Text == "" || txtStock.Text == "" || txtBarcode.Text == "")
                {
                    MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            Display();
            conn.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string addstock = "update logindb.products set stock = stock + '" + int.Parse(txtStock.Text) + "'where productsID = '" + int.Parse(txtProductID.Text) + "'";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(addstock, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Stock Added", "Notification");
                }

                else
                {
                    MessageBox.Show("Stock Not Added", "Notification");
                }
            }
            catch
            {
                if (txtProductID.Text == "" || txtProductName.Text == "" || txtPrice.Text == "" || txtDescription.Text == "" || txtStock.Text == "" || txtBarcode.Text == "")
                {
                    MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Display();
            conn.Close();

           

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int barcodegen = rand.Next(10000000, 99999999);

            for (int i = 0; i < dataGridView_products.Rows.Count; i++)
            {

                int productcode = int.Parse(dataGridView_products.Rows[i].Cells[5].Value.ToString());

                if(barcodegen == productcode)
                {
                    barcodegen = rand.Next(10000000, 99999999);
                }


            }


            txtBarcode.Text = Convert.ToString(barcodegen);
            lblGenerate.Text = Convert.ToString(barcodegen);
        }


        public void DisplaySuppliers()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select * from suppliers right join licences on suppliers.licenceID = licences.idlicences";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_suppliers.DataSource = datatbl;
            }
            catch
            {

            }

        }


        private void Products_Load(object sender, EventArgs e)
        {
            conn.Open();
            Display();
            DisplaySuppliers();
            conn.Close();
        }

        public void Display()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select * from products inner join suppliers on suppliers.idsuppliers = products.supplerID";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_products.DataSource = datatbl;
            }
            catch
            {

            }

        }



        private void dataGridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow current = this.dataGridView_products.Rows[e.RowIndex];
                txtProductID.Text = current.Cells[0].Value.ToString();
                txtProductName.Text = current.Cells[1].Value.ToString();
                txtPrice.Text = current.Cells[2].Value.ToString();
                txtDescription.Text = current.Cells[3].Value.ToString();
                txtStock.Text = current.Cells[4].Value.ToString();
                txtBarcode.Text = current.Cells[5].Value.ToString();

                lblGenerate.Text = current.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            if (cmbSearch.Text == "Product Name")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from products where productName like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_products.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Price")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from products where price like '%" + Convert.ToDecimal(txtSearch.Text) + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_products.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Description")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from products where description like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_products.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Stock")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from products where stock like '%" + int.Parse(txtSearch.Text) + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_products.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Barcode")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from products where barcode like '%" + int.Parse(txtSearch.Text) + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_products.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Product ID")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from products where productsID like '%" + int.Parse(txtSearch.Text) + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_products.DataSource = datatbl;
            }

            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {

            List<int> productIDs = new List<int>();
            conn.Open();

            string query = "SELECT productsID FROM logindb.products";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productIDs.Add(reader.GetInt32("productsID"));
                    }
                }
            }

            productIDs.Sort();
            int newID = 1;
            foreach (int id in productIDs)
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

            txtProductID.Text = newID.ToString();
        }

        private void dataGridView_suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_suppliers.Rows[e.RowIndex];
                txtSupplierID.Text = current.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
