using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sales_System
{

    public partial class Licences : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        public Licences()
        {
            InitializeComponent();
        }

        public void DisplayLicences()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select * from licences";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_licences.DataSource = datatbl;
            }
            catch
            {

            }

        }




        private void Licences_Load(object sender, EventArgs e)
        {
            conn.Open();
            DisplayLicences();
            conn.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int numbergen = rand.Next(10000000, 99999999);

            for (int i = 0; i < dataGridView_licences.Rows.Count; i++)
            {

                int licencecode = int.Parse(dataGridView_licences.Rows[i].Cells[2].Value.ToString());

                if (numbergen == licencecode)
                {
                    numbergen = rand.Next(10000000, 99999999);
                }


            }


            txtLicence.Text = Convert.ToString(numbergen);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            if (txtID.Text != "" && txtStart.Text != "" && txtEnd.Text != "" && txtType.Text != "" && txtLicence.Text != "" && int.Parse(txtID.Text) > 0 && int.Parse(txtLicence.Text) > 0)
            {

                try
                {
                    string insert = "insert into logindb.licences(idlicences, LicenceType, licenceNumber, startDate, expiryDate) values('" + int.Parse(txtID.Text) + "','" + txtType.Text + "','" + int.Parse(txtLicence.Text) + "','" + txtStart.Text + "','" + txtEnd.Text + "')";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(insert, conn);


                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Licence Created", "Notification");
                    }

                    else
                    {
                        MessageBox.Show("Licence Not Inserted", "Notification");
                    }


                 
                   

                   

                }

                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplayLicences();
                conn.Close();




            }


           else if (txtType.Text != "PREMIUM" || txtType.Text != "BASIC")
            {

                MessageBox.Show("Error - Two types exist PREMIUM and BASIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else if (txtLicence.Text.Length != 8)
            {
                MessageBox.Show("Invalid Licence Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtStart.Text != "" && txtEnd.Text != "" && txtType.Text != "" && txtLicence.Text != "" && int.Parse(txtID.Text) > 0 && int.Parse(txtLicence.Text) > 0)
            {
                try
                {


                    string delete = "delete from logindb.licences where idlicences = " + int.Parse(txtID.Text);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(delete, conn);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Licence Deleted", "Notification");
                    }

                    else
                    {
                        MessageBox.Show("Licence Not Deleted", "Notification");
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplayLicences();
                conn.Close();



            }

            else if (txtLicence.Text.Length != 8)
            {
                MessageBox.Show("Invalid Licence Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtStart.Text != "" && txtEnd.Text != "" && txtType.Text != "" && txtLicence.Text != "" && int.Parse(txtID.Text) > 0 && int.Parse(txtLicence.Text) > 0)
            {

                try
                {
                    string update = "update logindb.licences set LicenceType = '" + txtType.Text + "',licenceNumber = '" + int.Parse(txtLicence.Text) + "' ,startDate = '" + txtStart.Text + "',expiryDate = '" + txtEnd.Text + "'where idlicences = '" + int.Parse(txtID.Text) + "'";


                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(update, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Licence Updated", "Notification");
                    }

                    else
                    {
                        MessageBox.Show("Licence Not Updated", "Notification");
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplayLicences();
                conn.Close();




            }
            else if (txtLicence.Text.Length != 8)
            {
                MessageBox.Show("Invalid Licence Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtType.Clear();
            txtLicence.Clear();
            txtStart.Clear();
            txtEnd.Clear();
            txtID.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            conn.Open();
            DisplayLicences();
            txtSearch.Clear();
            cmbSearch.SelectedItem = null;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text == "Licence Type")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from licences where LicenceType like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_licences.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Licence Number")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from licences where licenceNumber like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_licences.DataSource = datatbl;
            }


            else if (cmbSearch.Text == "Start Date")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from licences where startDate like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_licences.DataSource = datatbl;
            }



            else if (cmbSearch.Text == "Expiry Date")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from licences where expiryDate like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_licences.DataSource = datatbl;
            }


            else if (cmbSearch.Text == "Licence ID")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from licences where idlicences like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_licences.DataSource = datatbl;
            }

            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        private void dataGridView_licences_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_licences.Rows[e.RowIndex];
                txtID.Text = current.Cells[0].Value.ToString();
                txtType.Text = current.Cells[1].Value.ToString();
                txtLicence.Text = current.Cells[2].Value.ToString();
                txtStart.Text = current.Cells[3].Value.ToString();
                txtEnd.Text = current.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            List<int> LicenseIDs = new List<int>();
            conn.Open();

            string query = "SELECT idlicences FROM logindb.licences";

            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LicenseIDs.Add(reader.GetInt32("idlicences"));
                    }
                }
            }

            LicenseIDs.Sort();
            int newID = 1;
            foreach (int id in LicenseIDs)
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
