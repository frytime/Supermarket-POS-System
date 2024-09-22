using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Windows.Threading;
using System.Collections.Generic;

namespace Sales_System
{
    public partial class MenuForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        DispatcherTimer mydispatcherTimer = new DispatcherTimer();
        public MenuForm()
        {
            mydispatcherTimer.Tick += new EventHandler(TimeInterval);
            mydispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            mydispatcherTimer.Start();

            InitializeComponent();
        }

        public void TimeInterval(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DisplayProducts();
                conn.Close();
            }
            catch
            {

            }
        }


        public double Cost()
        {
            double subtotal = 0;
            try
            {
                for (int i = 0; i <= dataGridView_basket.Rows.Count; i++)
                {
                    subtotal = subtotal + (Convert.ToDouble(dataGridView_basket.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView_basket.Rows[i].Cells[3].Value));
                }

            }
            catch
            {

            }

            return subtotal;

        }

        public void Calculate()
        {

            try
            {
                if (dataGridView_basket.Rows.Count > 0)
                {
                    double cost = Cost();

                    double tax = Math.Round(CalculateFunction.CalculateTax(cost), 2);

                    txtTax.Text = Convert.ToString(tax);

                    txtSubTotal.Text = Convert.ToString(cost);

                    double total = Math.Round(CalculateFunction.CalculateTotal(cost), 2);

                    txtTotal.Text = Convert.ToString(total);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public void Purchase()
        {
           
            try
            {
                if (dataGridView_basket.Rows.Count > 0)
                {
                    double cost = Cost();
                    double tax = Math.Round(CalculateFunction.CalculateTax(cost), 2);
                    double cash = Convert.ToDouble(txtCash.Text);




                    txtChange.Text = Math.Round(PurchaseFunction.CalculatePurchase(cost, tax, cash), 2).ToString();

                    


                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users myUsers = new Users();
            myUsers.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees myEmployees = new Employees();
            myEmployees.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products myProducts = new Products();
            myProducts.Show();
        }

        public void DisplayBasket()
        {
            try
            {
                MySqlCommand basket = conn.CreateCommand();
                basket.CommandType = CommandType.Text;
                basket.CommandText = "select productID, productName, price, quantity from products inner join baskets on products.productsID = baskets.productID";
                basket.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(basket);
                adapter.Fill(datatbl);
                dataGridView_basket.DataSource = datatbl;
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void MenuForm_Load(object sender, EventArgs e)
        {

            txtSubTotal.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";
            txtChange.Text = "0";
            conn.Open();
            DisplayProducts();
            DisplayBasket();
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        public void DisplayProducts()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select * from products";
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            conn.Open();
            DisplayProducts();
            txtSearch.Clear();
            cmbSearch.SelectedItem = null;
            conn.Close();
        }

        private void dataGridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_products.Rows[e.RowIndex];
                txtProductID.Text = current.Cells[0].Value.ToString();
                txtProductName.Text = current.Cells[1].Value.ToString();
                txtPrice.Text = current.Cells[2].Value.ToString();
                txtStock.Text = current.Cells[4].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtProductID.Clear();
            numQuantity.Text = "0";

            txtCustomerName.Clear();


            txtCash.Clear();
            txtSubTotal.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";
            txtChange.Text = "0";

        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text != "" && txtProductID.Text != "0" && int.Parse(numQuantity.Text) > 0 && int.Parse(numQuantity.Text) < int.Parse(txtStock.Text))
                {
                    try
                    {
                        string add = "insert into logindb.baskets(productID, quantity) values('" + int.Parse(txtProductID.Text) + "','" + int.Parse(numQuantity.Text) + "')";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(add, conn);


                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Added To Basket", "Notification");
                        }

                        else
                        {
                            MessageBox.Show("Not Added To Basket", "Notification");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DisplayBasket();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {


            try
            {
                string update = "update logindb.baskets set quantity = quantity - "+ int.Parse(numQuantity.Text) +" where productID = " + int.Parse(txtProductID.Text) + "";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(update, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Quantity deducted", "Notification");
                }
                else
                {
                    MessageBox.Show("Item Not Removed", "Notification");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayBasket();

            for (int i = 0; i < dataGridView_basket.RowCount; i++)
            {
                double quantity = Convert.ToDouble(dataGridView_basket.Rows[i].Cells[3].Value);

                if (quantity <= 0)
                {
                    string delete = "delete from logindb.baskets where productID = " + Convert.ToDouble(txtProductID.Text) +"";
                    MySqlCommand cmd1 = new MySqlCommand(delete, conn);
                    cmd1.ExecuteNonQuery();
                }
            }

            DisplayBasket();
            conn.Close();

        }

        private void dataGridView_basket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current = this.dataGridView_basket.Rows[e.RowIndex];
                txtProductID.Text = current.Cells[0].Value.ToString();
                txtProductName.Text = current.Cells[1].Value.ToString();
                txtPrice.Text = current.Cells[2].Value.ToString();
                numQuantity.Text = current.Cells[3].Value.ToString();
            }
            catch
            {

            }

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales mySales = new Sales();
            mySales.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orders myOrders = new Orders();
            myOrders.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers myCustomers = new Customers();
            myCustomers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Information myInformation = new Information();
            myInformation.Show();
        }

        private void dataGridView_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCash.Text != "" && txtCustomerName.Text != "")
            {
                string customerName = txtCustomerName.Text;
                int IDcustomer = -1;

                try
                {
                    conn.Open();

                    string query = "SELECT idcustomers FROM customers WHERE customerName = @customerName ";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@customerName", customerName);
                     
                        using (MySqlDataReader reading = command.ExecuteReader())
                        {
                            while (reading.Read())
                            {
                                IDcustomer = reading.GetInt32("idcustomers");
                            }
                        }
          
                    }


                    if (IDcustomer == -1)
                    {
                        List<int> customerIDs = new List<int>();

                        string query1 = "SELECT idcustomers FROM logindb.customers";
                        using (MySqlCommand command = new MySqlCommand(query1, conn))
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

                        string saveCustomer = "insert into logindb.customers(idcustomers, customerName) values('" + newID + "','" + txtCustomerName.Text + "')";

                        MySqlCommand cmd = new MySqlCommand(saveCustomer, conn);
                        cmd.ExecuteNonQuery();

                        IDcustomer = newID;
                    }

                    DateTime dateTime = DateTime.Now;
                    string saveOrder = "insert into logindb.orders(idorders, totalamount, date, customerID) values('" + Convert.ToDouble(txtOrderID.Text) + "','" + Convert.ToDouble(txtTotal.Text) + "','" + Convert.ToString(dateTime) + "','" + IDcustomer + "')";
                    MySqlCommand cmd2 = new MySqlCommand(saveOrder, conn);

                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Order Saved", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Order Not Saved", "Notification");
                    }

                    for (int i = 0; i < dataGridView_basket.Rows.Count; i++)
                    {
                        int ID = Convert.ToInt32(dataGridView_basket.Rows[i].Cells[0].Value);
                        int quantity = Convert.ToInt32(dataGridView_basket.Rows[i].Cells[3].Value);
                        string linkquery = "insert into logindb.orderproductlink(orderID, productID, quantity) values('" + Convert.ToDouble(txtOrderID.Text) + "','" + ID + "','" + quantity + "')";
                        MySqlCommand cmd3 = new MySqlCommand(linkquery, conn);
                        cmd3.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtCash.Text != "" && txtCustomerName.Text != "" && double.Parse(txtCash.Text) >= double.Parse(txtTotal.Text))
            {
                Purchase();
                try
                {
                    for (int i = 0; i < dataGridView_basket.Rows.Count; i++)
                    {
                        int quantityvalue = int.Parse(dataGridView_basket.Rows[i].Cells[3].Value.ToString());
                        int idvalue = int.Parse(dataGridView_basket.Rows[i].Cells[0].Value.ToString());
                        string reductstock = "update logindb.products set stock = stock - '" + quantityvalue + "'where productsID = '" + idvalue + "'";
                        conn.Open();
                        MySqlCommand stockcommand = new MySqlCommand(reductstock, conn);
                        stockcommand.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Payment Successful", "Notification", MessageBoxButtons.OK);

                }
                catch
                {
                    MessageBox.Show("Payment Unsuccessful", "Notification", MessageBoxButtons.OK);
                }
            }

            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView_basket_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

            Calculate();

            if (dataGridView_basket == null || dataGridView_basket.Rows.Count == 0)
            {
                txtCash.Clear();
                txtSubTotal.Text = "0";
                txtTax.Text = "0";
                txtTotal.Text = "0";
                txtChange.Text = "0";

            }
        }

        private void dataGridView_basket_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Calculate();

            if (dataGridView_basket == null || dataGridView_basket.Rows.Count == 0)
            {
                txtCash.Clear();
                txtSubTotal.Text = "0";
                txtTax.Text = "0";
                txtTotal.Text = "0";
                txtChange.Text = "0";

            }
        }

        private void dataGridView_basket_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calculate();

            if (dataGridView_basket == null || dataGridView_basket.Rows.Count == 0)
            {
                txtCash.Clear();
                txtSubTotal.Text = "0";
                txtTax.Text = "0";
                txtTotal.Text = "0";
                txtChange.Text = "0";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCash.Text != "" && txtCustomerName.Text != "" && double.Parse(txtCash.Text) >= double.Parse(txtTotal.Text) && txtChange.Text != "" && txtTotal.Text != "" && txtSubTotal.Text != "" && txtTax.Text != "" && dataGridView_basket != null)
                {

                    Random rand = new Random();

                    int recieptnum = rand.Next(10000000, 99999999);


                    TextWriter Printer = new StreamWriter("Receipt-'" + recieptnum.ToString() + "'.txt");
                    Printer.WriteLine("Date and Time: " + DateTime.Now);
                    Printer.WriteLine("Receipt Number: " + recieptnum.ToString());
                    Printer.WriteLine("");
                    Printer.WriteLine("Customer: " + txtCustomerName.Text);
                    Printer.WriteLine("");
                    Printer.WriteLine("Products:");
                    Printer.WriteLine("-----------------------------------------------------");
                    Printer.WriteLine("");
                    for (int i = 0; i < dataGridView_basket.Rows.Count; i++)
                    {

                        double amount =  (Convert.ToDouble(dataGridView_basket.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView_basket.Rows[i].Cells[3].Value));
                        Printer.WriteLine("Item:" + (i + 1).ToString());
                        Printer.WriteLine("Product Name: " + dataGridView_basket.Rows[i].Cells[1].Value.ToString() + "  Quantity: " + dataGridView_basket.Rows[i].Cells[3].Value.ToString() + "  Price: " + dataGridView_basket.Rows[i].Cells[2].Value.ToString() + " Total Price:  " + amount.ToString());


                    }
                    Printer.WriteLine("");
                    Printer.WriteLine("-----------------------------------------------------");
                    Printer.WriteLine("Subtotal: " + txtSubTotal.Text);
                    Printer.WriteLine("Tax: " + txtTax.Text);
                    Printer.WriteLine("Total: " + txtTotal.Text);
                    Printer.WriteLine("");

                    Printer.WriteLine("Cash Tendered: " + txtCash.Text);
                    Printer.WriteLine("Change: " + txtChange.Text);

                    Printer.Close();
                    MessageBox.Show("Receipt Printed");
                    Process.Start("notepad.exe", @"Receipt-'" + recieptnum.ToString() + "'.txt");
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

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Calculator myCalculator = new Calculator();
            myCalculator.Show();
        }

     
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers mySuppliers = new Suppliers();
            mySuppliers.Show();
        }

        private void btnLicences_Click(object sender, EventArgs e)
        {
            Licences myLicences = new Licences();
            myLicences.Show();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            Backup myBackup = new Backup();
            myBackup.Show();
        }
    }
}

