using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Sales_System
{
    public partial class Employees : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");

        public Employees()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtJob.Clear();
            txtEmail.Clear();
            txtEmployeeID.Clear();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtJob.Text != "" && txtEmployeeID.Text != "" && int.Parse(txtEmployeeID.Text) > 0)
                {
                    try
                    {

                        string insert = "insert into logindb.employees(employeesID, firstname, lastname, address, job, email, IDuser) values('" + int.Parse(txtEmployeeID.Text) + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtAddress.Text + "','" + txtJob.Text + "','" + txtEmail.Text + "','" + int.Parse(txtID.Text) + "')";
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
                        if (txtEmployeeID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtJob.Text == "" || txtEmail.Text == "")
                        {
                            MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            MessageBox.Show("User details must be inserted first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    Display();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (txtFirstName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtJob.Text != "" && txtEmployeeID.Text != "" && int.Parse(txtEmployeeID.Text) > 0)
                {


                    string delete = "delete from logindb.employees where employeesID = " + int.Parse(txtEmployeeID.Text);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(delete, conn);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Employee Deleted", "Notification");
                    }

                    else
                    {
                        MessageBox.Show("Employee Not Deleted", "Notification");
                    }


                    Display();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void Display()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select * from employees right join users on employees.IDuser = users.userID";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_employees.DataSource = datatbl;
            }
            catch
            {

            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtJob.Text != "" && txtEmployeeID.Text != "" && int.Parse(txtEmployeeID.Text) > 0)
                {
                    try
                    {
                        string update = "update logindb.employees set firstname = '" + txtFirstName.Text + "',lastname = '" + txtLastName.Text + "',address = '" + txtAddress.Text + "' ,job = '" + txtJob.Text + "',email = '" + txtEmail.Text + "' where employeesID = '" + int.Parse(txtEmployeeID.Text) + "'";


                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(update, conn);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Employee Updated", "Notification");
                        }

                        else
                        {
                            MessageBox.Show("Employee Not Updated", "Notification");
                        }
                    }
                    catch
                    {
                        if (txtEmployeeID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtJob.Text == "" || txtEmail.Text == "")
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
                else
                {
                    MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            conn.Open();
            Display();
            conn.Close();
        }

        private void dataGridView_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_employees.Rows[e.RowIndex];
                txtEmployeeID.Text = current.Cells[0].Value.ToString();
                txtFirstName.Text = current.Cells[1].Value.ToString();
                txtLastName.Text = current.Cells[2].Value.ToString();
                txtAddress.Text = current.Cells[3].Value.ToString();
                txtJob.Text = current.Cells[4].Value.ToString();
                txtEmail.Text = current.Cells[5].Value.ToString();
            }
            catch
            {

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text == "First Name")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from employees where firstname like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_employees.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Last Name")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from employees where lastname like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_employees.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Address")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from employees where address like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_employees.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Job")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from employees where job like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_employees.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Email")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from employees where email like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_employees.DataSource = datatbl;
            }

            else if (cmbSearch.Text == "Employee ID")
            {
                conn.Open();
                MySqlCommand dsply = conn.CreateCommand();
                dsply.CommandType = CommandType.Text;
                dsply.CommandText = "select * from employees where employeesID like '%" + txtSearch.Text + "%'";
                dsply.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(dsply);
                adapter.Fill(datatbl);
                dataGridView_employees.DataSource = datatbl;
            }

            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int listnum = rand.Next(10000000, 99999999);


            TextWriter Printer = new StreamWriter("Reciept-'" + listnum.ToString() + "'.txt");
            Printer.WriteLine("Date and Time: " + DateTime.Now);
            Printer.WriteLine("List Number: " + listnum.ToString());
            Printer.WriteLine("");
            Printer.WriteLine("Employees");
            Printer.WriteLine("-----------------------------------------------------");
            Printer.WriteLine("");
            for (int i = 0; i < dataGridView_employees.Rows.Count; i++)
            {

                if (dataGridView_employees.Rows[i].Cells[0].Value.ToString() != "" && dataGridView_employees.Rows[i].Cells[1].Value.ToString() != "" && dataGridView_employees.Rows[i].Cells[2].Value.ToString() != "" && dataGridView_employees.Rows[i].Cells[4].Value.ToString() != "")
                {

                    Printer.WriteLine("Employee:" + (i + 1).ToString());
                    Printer.WriteLine("Employee ID: " + dataGridView_employees.Rows[i].Cells[0].Value.ToString() + "  First Name: " + dataGridView_employees.Rows[i].Cells[1].Value.ToString() + "  Last Name: " + dataGridView_employees.Rows[i].Cells[2].Value.ToString() + " Job:  " + dataGridView_employees.Rows[i].Cells[4].Value.ToString());
                    Printer.WriteLine("-----------------------------------------------------");
                }

             


            }

            Printer.Close();
            MessageBox.Show("List Printed");
            Process.Start("notepad.exe", @"Reciept-'" + listnum.ToString() + "'.txt");
        }

        private void btn_Recommend_Click(object sender, EventArgs e)
        {

            List<int> employeeIDs = new List<int>();
            conn.Open();

            string query = "SELECT employeesID FROM logindb.employees";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employeeIDs.Add(reader.GetInt32("employeesID"));
                    }
                }
            }

            employeeIDs.Sort();
            int newID = 1;
            foreach (int id in employeeIDs)
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

            txtEmployeeID.Text = newID.ToString();
        }
    }
}
