
namespace Sales_System
{
    partial class Backup
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
            this.FTPSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_Retrieve = new System.Windows.Forms.Button();
            this.list_FTP = new System.Windows.Forms.ListBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileDelete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FTPSave
            // 
            this.FTPSave.Location = new System.Drawing.Point(12, 298);
            this.FTPSave.Name = "FTPSave";
            this.FTPSave.Size = new System.Drawing.Size(308, 23);
            this.FTPSave.TabIndex = 0;
            this.FTPSave.Text = "Save Database in FTP Server";
            this.FTPSave.UseVisualStyleBackColor = true;
            this.FTPSave.Click += new System.EventHandler(this.FTPSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 25);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn_Retrieve
            // 
            this.btn_Retrieve.Location = new System.Drawing.Point(12, 327);
            this.btn_Retrieve.Name = "btn_Retrieve";
            this.btn_Retrieve.Size = new System.Drawing.Size(308, 23);
            this.btn_Retrieve.TabIndex = 36;
            this.btn_Retrieve.Text = "Show Contents of FTP Server";
            this.btn_Retrieve.UseVisualStyleBackColor = true;
            this.btn_Retrieve.Click += new System.EventHandler(this.btn_Retrieve_Click);
            // 
            // list_FTP
            // 
            this.list_FTP.FormattingEnabled = true;
            this.list_FTP.ItemHeight = 16;
            this.list_FTP.Location = new System.Drawing.Point(12, 81);
            this.list_FTP.Name = "list_FTP";
            this.list_FTP.Size = new System.Drawing.Size(308, 212);
            this.list_FTP.TabIndex = 37;
            this.list_FTP.SelectedIndexChanged += new System.EventHandler(this.list_FTP_SelectedIndexChanged);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(441, 271);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(297, 22);
            this.txtFile.TabIndex = 38;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(364, 274);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(71, 17);
            this.lblCustomerName.TabIndex = 39;
            this.lblCustomerName.Text = "File Name";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(441, 299);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(297, 23);
            this.btnImport.TabIndex = 40;
            this.btnImport.Text = "Import Database";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(297, 23);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete Database";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "File Name";
            // 
            // txtFileDelete
            // 
            this.txtFileDelete.Location = new System.Drawing.Point(441, 132);
            this.txtFileDelete.Name = "txtFileDelete";
            this.txtFileDelete.Size = new System.Drawing.Size(297, 22);
            this.txtFileDelete.TabIndex = 41;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileDelete);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.list_FTP);
            this.Controls.Add(this.btn_Retrieve);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.FTPSave);
            this.Name = "Backup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FTPSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn_Retrieve;
        private System.Windows.Forms.ListBox list_FTP;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileDelete;
    }
}