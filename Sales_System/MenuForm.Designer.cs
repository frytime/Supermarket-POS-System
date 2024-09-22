
namespace Sales_System
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.dataGridView_basket = new System.Windows.Forms.DataGridView();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLicences = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(11, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(227, 10);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(96, 25);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(328, 10);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(96, 25);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(429, 10);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(96, 25);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(469, 69);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 25);
            this.btnReset.TabIndex = 74;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 25);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(121, 69);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 22);
            this.txtSearch.TabIndex = 72;
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Product Name",
            "Price",
            "Description",
            "Stock",
            "Barcode",
            "Product ID"});
            this.cmbSearch.Location = new System.Drawing.Point(9, 68);
            this.cmbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(108, 24);
            this.cmbSearch.TabIndex = 71;
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.AllowUserToAddRows = false;
            this.dataGridView_products.AllowUserToDeleteRows = false;
            this.dataGridView_products.AllowUserToResizeColumns = false;
            this.dataGridView_products.AllowUserToResizeRows = false;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Location = new System.Drawing.Point(11, 96);
            this.dataGridView_products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.ReadOnly = true;
            this.dataGridView_products.RowHeadersWidth = 62;
            this.dataGridView_products.RowTemplate.Height = 28;
            this.dataGridView_products.Size = new System.Drawing.Size(555, 279);
            this.dataGridView_products.TabIndex = 70;
            this.dataGridView_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_products_CellClick);
            this.dataGridView_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_products_CellContentClick);
            // 
            // dataGridView_basket
            // 
            this.dataGridView_basket.AllowUserToAddRows = false;
            this.dataGridView_basket.AllowUserToDeleteRows = false;
            this.dataGridView_basket.AllowUserToResizeColumns = false;
            this.dataGridView_basket.AllowUserToResizeRows = false;
            this.dataGridView_basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_basket.Location = new System.Drawing.Point(605, 96);
            this.dataGridView_basket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_basket.Name = "dataGridView_basket";
            this.dataGridView_basket.ReadOnly = true;
            this.dataGridView_basket.RowHeadersWidth = 62;
            this.dataGridView_basket.RowTemplate.Height = 28;
            this.dataGridView_basket.Size = new System.Drawing.Size(529, 279);
            this.dataGridView_basket.TabIndex = 77;
            this.dataGridView_basket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_basket_CellClick);
            this.dataGridView_basket.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_basket_RowsAdded);
            this.dataGridView_basket.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_basket_RowsRemoved);
            this.dataGridView_basket.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView_basket_RowStateChanged);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(207, 449);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 78;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(140, 450);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 79;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(207, 417);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(120, 22);
            this.txtProductName.TabIndex = 83;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(103, 420);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 82;
            this.lblProductName.Text = "Product Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(207, 478);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 22);
            this.txtPrice.TabIndex = 81;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(161, 481);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(40, 17);
            this.lblLastName.TabIndex = 80;
            this.lblLastName.Text = "Price";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(832, 399);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(304, 22);
            this.txtCustomerName.TabIndex = 85;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(716, 401);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 84;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(227, 574);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 25);
            this.btnClear.TabIndex = 86;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.Location = new System.Drawing.Point(343, 447);
            this.btnBasket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(120, 25);
            this.btnBasket.TabIndex = 87;
            this.btnBasket.Text = "Add To Basket";
            this.btnBasket.UseVisualStyleBackColor = true;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(343, 478);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 25);
            this.btnRemove.TabIndex = 88;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(633, 10);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(96, 25);
            this.btnCustomers.TabIndex = 7;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(836, 10);
            this.btnSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(96, 25);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotal.Location = new System.Drawing.Point(793, 526);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 96;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(735, 530);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 95;
            this.lblTotal.Text = "Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSubTotal.Location = new System.Drawing.Point(793, 441);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubTotal.TabIndex = 94;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTax.Location = new System.Drawing.Point(793, 482);
            this.txtTax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 93;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(743, 486);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 17);
            this.lblTax.TabIndex = 92;
            this.lblTax.Text = "Tax";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(715, 443);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(69, 17);
            this.lblSubTotal.TabIndex = 91;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChange.Location = new System.Drawing.Point(1033, 481);
            this.txtChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(100, 22);
            this.txtChange.TabIndex = 102;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(967, 486);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(57, 17);
            this.lblChange.TabIndex = 101;
            this.lblChange.Text = "Change";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(921, 442);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(106, 17);
            this.lblCash.TabIndex = 98;
            this.lblCash.Text = "Cash Tendered";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(1033, 438);
            this.txtCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(100, 22);
            this.txtCash.TabIndex = 99;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1015, 513);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 25);
            this.btnSave.TabIndex = 103;
            this.btnSave.Text = "Save Order";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1015, 545);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 25);
            this.btnPrint.TabIndex = 104;
            this.btnPrint.Text = "Print Reciept";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(735, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "Product ID*";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(207, 510);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(120, 22);
            this.txtProductID.TabIndex = 107;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(1015, 577);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(120, 25);
            this.btnPay.TabIndex = 108;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOrderID.Location = new System.Drawing.Point(793, 574);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 22);
            this.txtOrderID.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "Order ID*";
            // 
            // btnLicences
            // 
            this.btnLicences.Location = new System.Drawing.Point(937, 10);
            this.btnLicences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLicences.Name = "btnLicences";
            this.btnLicences.Size = new System.Drawing.Size(96, 25);
            this.btnLicences.TabIndex = 10;
            this.btnLicences.Text = "Licences";
            this.btnLicences.UseVisualStyleBackColor = true;
            this.btnLicences.Click += new System.EventHandler(this.btnLicences_Click);
            // 
            // g
            // 
            this.g.Location = new System.Drawing.Point(125, 10);
            this.g.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(96, 25);
            this.g.TabIndex = 2;
            this.g.Text = "Calculator";
            this.g.UseVisualStyleBackColor = true;
            this.g.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStock.Location = new System.Drawing.Point(205, 542);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(120, 22);
            this.txtStock.TabIndex = 112;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(153, 545);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 111;
            this.lblStock.Text = "Stock";
            // 
            // btn_Backup
            // 
            this.btn_Backup.Location = new System.Drawing.Point(937, 39);
            this.btn_Backup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(202, 25);
            this.btn_Backup.TabIndex = 114;
            this.btn_Backup.Text = "Backup";
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(1039, 10);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(96, 25);
            this.btnSuppliers.TabIndex = 113;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 638);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.g);
            this.Controls.Add(this.btnLicences);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.dataGridView_basket);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.dataGridView_products);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.DataGridView dataGridView_basket;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLicences;
        private System.Windows.Forms.Button g;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btnSuppliers;
    }
}