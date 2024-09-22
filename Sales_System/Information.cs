using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sales_System
{
    public partial class Information : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");

        public Information()
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

        private void Information_Load(object sender, EventArgs e)
        {

            conn.Open();
            DisplayTotalEmployees();
            DisplayTotalProducts();
            DisplayTotalLicences();
            DisplayTotalSuppliers();
            DisplayTotalProfit();
            DisplayTotalUsers();
            DisplayAverageProductPrice();
            DisplayCheapestProduct();
            DisplayExpensiveProduct();
            DisplayTotalSales();
            DisplayTotalBasics();
            DisplayTotalPremiums();
            conn.Close();



        }


      


        public void DisplayTotalEmployees()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select count(employeesID) as 'Total Employees' from employees";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_totalEmployees.DataSource = datatbl;
            }
            catch
            {

            }

        }



        public void DisplayTotalProducts()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select count(productsID) as 'Total Products' from products";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_totalProducts.DataSource = datatbl;
            }
            catch
            {

            }

        }


        public void DisplayTotalProfit()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select sum(totalamount) as 'Total Profit' from orders";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_totalProfit.DataSource = datatbl;
            }
            catch
            {

            }

        }



        public void DisplayTotalUsers()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select count(userID) as 'Total Users' from users";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_totalUsers.DataSource = datatbl;
            }
            catch
            {

            }

        }


        public void DisplayTotalSales()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select count(idorders) as 'Total Sales' from orders";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_totalSales.DataSource = datatbl;
            }
            catch
            {

            }

        }


        public void DisplayAverageProductPrice()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select avg(price) as 'Average Price' from products";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_averageProductPrice.DataSource = datatbl;
            }
            catch
            {

            }

        }


        public void DisplayCheapestProduct()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select min(price) as 'Cheapest Product Price' from products";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_cheapestProduct.DataSource = datatbl;
            }
            catch
            {

            }

        }

        public void DisplayExpensiveProduct()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select max(price) as 'Expensive Product Price' from products";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_ExpensiveProduct.DataSource = datatbl;
            }
            catch
            {

            }

        }


        public void DisplayTotalLicences()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select count(idlicences) as 'Total Licences' from licences";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_LicencesCount.DataSource = datatbl;
            }
            catch
            {

            }

        }

        public void DisplayTotalPremiums()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select count(idlicences) as 'Total Premiums' from licences where LicenceType = 'PREMIUM'";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_PremiumCount.DataSource = datatbl;
            }
            catch
            {

            }

        }

        public void DisplayTotalBasics()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select count(idlicences) as 'Total Basics' from licences where LicenceType = 'BASIC'";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView1_BasicCount.DataSource = datatbl;
            }
            catch
            {

            }

        }

        public void DisplayTotalSuppliers()
        {
            try
            {
                MySqlCommand display = conn.CreateCommand();
                display.CommandType = CommandType.Text;
                display.CommandText = "select count(idsuppliers) as 'Total Suppliers' from suppliers";
                display.ExecuteNonQuery();
                DataTable datatbl = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(display);
                adapter.Fill(datatbl);
                dataGridView_SuppliersCount.DataSource = datatbl;
            }
            catch
            {

            }

        }






















    }
}
