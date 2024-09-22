
namespace Sales_System
{
    partial class Licences
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView_licences = new System.Windows.Forms.DataGridView();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnRecommend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_licences)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 25);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(208, 226);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 80;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(117, 230);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(79, 17);
            this.lblOrderID.TabIndex = 79;
            this.lblOrderID.Text = "Licence ID*";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(139, 183);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(168, 22);
            this.txtEnd.TabIndex = 77;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(39, 187);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 17);
            this.lblDate.TabIndex = 76;
            this.lblDate.Text = "Expiry Date";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(941, 17);
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
            this.btnSearch.Location = new System.Drawing.Point(840, 17);
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
            this.txtSearch.Location = new System.Drawing.Point(596, 18);
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
            "Licence Type",
            "Licence Number",
            "Start Date",
            "Expiry Date",
            "Licence ID"});
            this.cmbSearch.Location = new System.Drawing.Point(483, 18);
            this.cmbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(108, 24);
            this.cmbSearch.TabIndex = 71;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(140, 289);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 25);
            this.btnClear.TabIndex = 70;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView_licences
            // 
            this.dataGridView_licences.AllowUserToAddRows = false;
            this.dataGridView_licences.AllowUserToDeleteRows = false;
            this.dataGridView_licences.AllowUserToResizeColumns = false;
            this.dataGridView_licences.AllowUserToResizeRows = false;
            this.dataGridView_licences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_licences.Location = new System.Drawing.Point(481, 47);
            this.dataGridView_licences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_licences.Name = "dataGridView_licences";
            this.dataGridView_licences.ReadOnly = true;
            this.dataGridView_licences.RowHeadersWidth = 62;
            this.dataGridView_licences.RowTemplate.Height = 28;
            this.dataGridView_licences.Size = new System.Drawing.Size(555, 303);
            this.dataGridView_licences.TabIndex = 68;
            this.dataGridView_licences.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_licences_CellClick);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(171, 52);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(136, 22);
            this.txtType.TabIndex = 67;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(20, 102);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(111, 17);
            this.lblCustomerID.TabIndex = 65;
            this.lblCustomerID.Text = "Licence Number";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(69, 55);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(93, 17);
            this.lblCustomerName.TabIndex = 64;
            this.lblCustomerName.Text = "Licence Type";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 226);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 25);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(348, 142);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 25);
            this.btnInsert.TabIndex = 82;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 183);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 25);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(140, 144);
            this.txtStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(168, 22);
            this.txtStart.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Start Date";
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(139, 98);
            this.txtLicence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Size = new System.Drawing.Size(168, 22);
            this.txtLicence.TabIndex = 86;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(348, 98);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 25);
            this.btnGenerate.TabIndex = 87;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnRecommend
            // 
            this.btnRecommend.Location = new System.Drawing.Point(140, 256);
            this.btnRecommend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(169, 25);
            this.btnRecommend.TabIndex = 88;
            this.btnRecommend.Text = "Recommend";
            this.btnRecommend.UseVisualStyleBackColor = true;
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // Licences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 359);
            this.Controls.Add(this.btnRecommend);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtLicence);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView_licences);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licences";
            this.Text = "Licences";
            this.Load += new System.EventHandler(this.Licences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_licences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView_licences;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRecommend;
    }
}