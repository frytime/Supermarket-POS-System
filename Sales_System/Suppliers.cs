using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_System
{
    public partial class Suppliers : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        public Suppliers()
        {
            InitializeComponent();
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



        private void Suppliers_Load(object sender, EventArgs e)
        {
            conn.Open();
            DisplaySuppliers();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtSupplierID.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" && txtCompany.Text != "" && txtEmail.Text != "" && txtTelephone.Text != "" && int.Parse(txtSupplierID.Text) > 0)
            {
                try
                {


                    string delete = "delete from logindb.suppliers where idsuppliers = " + int.Parse(txtSupplierID.Text);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(delete, conn);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Supplier Deleted", "Notification");
                    }

                    else
                    {
                        MessageBox.Show("Supplier Not Deleted", "Notification");
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplaySuppliers();
                conn.Close();




            }



            else if (txtTelephone.Text.Length != 10)
            {
                MessageBox.Show("Invalid Telephone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        

                try
                {
                    string update = "update logindb.suppliers set firstName = '" + txtFirstName.Text + "',lastName = '" + txtLastName.Text + "',address = '" + txtAddress.Text + "' ,company = '" + txtCompany.Text + "',email = '" + txtEmail.Text + "',telephoneNum = '" + int.Parse(txtTelephone.Text) + "' where idsuppliers = '" + int.Parse(txtSupplierID.Text) + "'";


                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(update, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Supplier Updated", "Notification");
                    }

                    else
                    {
                        MessageBox.Show("Supplier Not Updated", "Notification");
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplaySuppliers();
                conn.Close();





           


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            try
            {

                string insert = "insert into logindb.suppliers(idsuppliers, firstName, lastName, address, company, email, telephoneNum, licenceID) values('" + int.Parse(txtSupplierID.Text) + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtAddress.Text + "','" + txtCompany.Text + "','" + txtEmail.Text + "','" + int.Parse(txtTelephone.Text) + "','" + int.Parse(txtID.Text) + "')";
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
                if (txtSupplierID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtTelephone.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Licence details must be inserted first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            DisplaySuppliers();
            conn.Close();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtCompany.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            txtSupplierID.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            conn.Open();
            DisplaySuppliers();
            txtSearch.Clear();
            cmbSearch.SelectedItem = null;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (cmbSearch.Text == "First Name")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from suppliers where firstName like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_suppliers.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Last Name")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from suppliers where lastName like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_suppliers.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Address")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from suppliers where address like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_suppliers.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Company")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from suppliers where company like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_suppliers.DataSource = datatbl;
            }


            else if (cmbSearch.Text == "Email")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from suppliers where email like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_suppliers.DataSource = datatbl;
            }


            else if (cmbSearch.Text == "Telephone Number")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from suppliers where telephoneNum like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_suppliers.DataSource = datatbl;
            }



            else if (cmbSearch.Text == "Supplier ID")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from suppliers where idsuppliers like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_suppliers.DataSource = datatbl;
            }

            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        private void dataGridView_suppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_suppliers.Rows[e.RowIndex];
                txtSupplierID.Text = current.Cells[0].Value.ToString();
                txtFirstName.Text = current.Cells[1].Value.ToString();
                txtLastName.Text = current.Cells[2].Value.ToString();
                txtAddress.Text = current.Cells[3].Value.ToString();
                txtCompany.Text = current.Cells[4].Value.ToString();
                txtEmail.Text = current.Cells[5].Value.ToString();
                txtTelephone.Text = current.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            List<int> supplierIDs = new List<int>();
            conn.Open();

            string query = "SELECT idsuppliers FROM logindb.suppliers";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        supplierIDs.Add(reader.GetInt32("idsuppliers"));
                    }
                }
            }


            supplierIDs.Sort();

            int newID = 1;

            foreach (int id in supplierIDs)
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

            txtSupplierID.Text = newID.ToString();
        }

        private void dataGridView_suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelephone_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSupplierID_Click(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblJob_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

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
    }
}

