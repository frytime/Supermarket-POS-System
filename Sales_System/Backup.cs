using System;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
using System.IO;


namespace Sales_System
{
    public partial class Backup : Form
    {
        string connString = ("server=127.0.0.1;user id=root;password=pass2005;persistsecurityinfo=True;database=logindb;port=3306");
        public Backup()
        {
            InitializeComponent();
        }

        private void FTPSave_Click(object sender, EventArgs e)
        {

            string date = DateTime.Now.ToString("yyyyMMddHHmmss");

            string path = "C:\\Users\\nasri\\OneDrive\\Documents\\Databases\\mybackup_" + date + ".sql";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(path);
                        conn.Close();
                    }
                }
            }

            using (WebClient client = new WebClient())
            {
                string address = "add your FTP address" + "backup-" + date + ".sql";


                client.Credentials = new NetworkCredential("ftp-user", "Thom2005!");
                client.UploadFile(address, path);
            }

            MessageBox.Show("Backup successful - Database stored in FTP Server", "Notification", MessageBoxButtons.OK);
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            string address = "ftp://82.35.85.44/";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(address);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential("ftp-user", "Thom2005!");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    while (!reader.EndOfStream)
                    {
                        list_FTP.Items.Add(reader.ReadLine());
                    }
                }
            }

            response.Close();

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

        private void btn_Retrieve_Click(object sender, EventArgs e)
        {
            list_FTP.Items.Clear();
            Display();

            MessageBox.Show("Display successful - FTP Server's contents are displayed", "Notification", MessageBoxButtons.OK);

        }

        private void list_FTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_FTP.SelectedItem != null)
            {
                txtFile.Text = list_FTP.SelectedItem.ToString();
                txtFileDelete.Text = list_FTP.SelectedItem.ToString();
            }
            else
            {
               txtFile.Text = "";
            }
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(txtFile.Text != "")
            {
                try
                {
                    string file = txtFile.Text;
                    string path = "C:\\Users\\nasri\\OneDrive\\Desktop\\work\\" + file;



                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conn;

                            MySqlBackup backup = new MySqlBackup(cmd);

                            backup.ImportFromFile(path);

                        }
                        conn.Close();
                    }

                    MessageBox.Show("Import successful - FTP Server's file has been retrieved", "Notification", MessageBoxButtons.OK);
                    

                }
                catch
                {
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
          
            else
            {
                MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtFileDelete.Text != "")
            {
                try
                {
                    string file = txtFile.Text;
                    string address = "ftp://82.35.85.44/";

                    FtpWebRequest client = (FtpWebRequest)WebRequest.Create(address + file);
                    client.Method = WebRequestMethods.Ftp.DeleteFile;
                    client.Credentials = new NetworkCredential("ftp-user", "Thom2005!");




                    using (FtpWebResponse response = (FtpWebResponse)client.GetResponse())
                    { 
                        MessageBox.Show("Database deletion successful - FTP Server's file has been deleted", "Notification", MessageBoxButtons.OK);
                    }

                }
                catch(IOException)
                {
                    MessageBox.Show("The database is in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
