using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;
namespace Lime_Contact_Manager
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32.dll")]
        static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);


        bool WriteINI(string SectionName, string KeyName, string StringToWrite, string INIFileName)
        {
            bool Return;
            Return = WritePrivateProfileString(SectionName, KeyName, StringToWrite, INIFileName);
            return Return;
        }

        private static string password = "194553";
        SQLiteConnection con = new SQLiteConnection();
     
        void baglan()
        {

            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
        }

        public void GetList()
            {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Selected == true)
                {

                    txtHomeAddress.Text = row.Cells[6].Value.ToString();
                    txtWorkAddressN.Text = row.Cells[7].Value.ToString();
                    txtEmail1.Text = row.Cells[8].Value.ToString();
                    txtEmail2.Text = row.Cells[9].Value.ToString();
                    txtWebSite1.Text = row.Cells[10].Value.ToString();
                    txtWebSite2.Text = row.Cells[11].Value.ToString();
                    txtTwitter.Text = row.Cells[12].Value.ToString();
                    txtFacebook.Text = row.Cells[13].Value.ToString();
                    txtLinkedin.Text = row.Cells[14].Value.ToString();
                    txtInstagram.Text = row.Cells[15].Value.ToString();
                }
            }
        }

        void totalRecords()
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
            SQLiteCommand comm2 = new SQLiteCommand("SELECT Count(VeriID) FROM [Veriler] where VeriID = VeriID", con);
            Object temp = comm2.ExecuteScalar();
            lblRecords.Text = temp.ToString();
        }
        
        void griddoldur()
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            dataGridView1.Rows.Clear();

            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" +set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Veriler", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
         
            read.GetValue(read.GetOrdinal("VeriID")),
            read.GetValue(read.GetOrdinal("Name")),
            read.GetValue(read.GetOrdinal("Surname"))
     });
                }
            }
        }

        void griddoldur2()
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            dataGridView2.Rows.Clear();

            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" +set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Veriler where VeriID=" + txtID.Text, con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView2.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("birthday")),
            read.GetValue(read.GetOrdinal("homephone")),
            read.GetValue(read.GetOrdinal("mobilephone")),
            read.GetValue(read.GetOrdinal("workphone")),
            read.GetValue(read.GetOrdinal("faxnumber")),
            read.GetValue(read.GetOrdinal("homeaddress")),
            read.GetValue(read.GetOrdinal("workaddress")),
            read.GetValue(read.GetOrdinal("job")),
            read.GetValue(read.GetOrdinal("email1")),
            read.GetValue(read.GetOrdinal("email2")),
            read.GetValue(read.GetOrdinal("website1")),
            read.GetValue(read.GetOrdinal("website2")),
            read.GetValue(read.GetOrdinal("twitter")),
            read.GetValue(read.GetOrdinal("facebook")),
            read.GetValue(read.GetOrdinal("linkedin")),
            read.GetValue(read.GetOrdinal("instagram")),
            read.GetValue(read.GetOrdinal("notes"))
     });
                }
            }
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            griddoldur();
            
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Surname";

            dataGridView2.Columns[0].HeaderText = "Birthday";
            dataGridView2.Columns[1].HeaderText = "Home Phone";
            dataGridView2.Columns[2].HeaderText = "Mobile Phone";
            dataGridView2.Columns[3].HeaderText = "Work Phone";
            dataGridView2.Columns[4].HeaderText = "Fax Number";
            dataGridView2.Columns[5].HeaderText = "Home Address";
            dataGridView2.Columns[6].HeaderText = "Work Address";
            dataGridView2.Columns[7].HeaderText = "Job";
            dataGridView2.Columns[8].HeaderText = "E-Mail(1)";
            dataGridView2.Columns[9].HeaderText = "E-Mail(2)";
            dataGridView2.Columns[10].HeaderText = "Website (1)";
            dataGridView2.Columns[11].HeaderText = "Website (2)";
            dataGridView2.Columns[12].HeaderText = "Twitter";
            dataGridView2.Columns[13].HeaderText = "Facebook";
            dataGridView2.Columns[14].HeaderText = "Linkedin";
            dataGridView2.Columns[15].HeaderText = "Instagram";
            dataGridView2.Columns[16].HeaderText = "Notes";

            totalRecords();

            this.toolTip1.SetToolTip(pbMail1, "Send Mail (1)");
            this.toolTip1.SetToolTip(pbMail2, "Send Mail (2)");
            this.toolTip1.SetToolTip(pbTwitter, "Open Twitter");
            this.toolTip1.SetToolTip(pbFacebook, "Open Facebook");
            this.toolTip1.SetToolTip(pbLinkedin, "Open Linkedin");
            this.toolTip1.SetToolTip(pbInstagram, "Open Instagram");
            this.toolTip1.SetToolTip(pbWeb1, "Open Website (1)");
            this.toolTip1.SetToolTip(pbWeb2, "Open Website (2)");
            this.toolTip1.SetToolTip(pbAddress1, "Open Home Address");
            this.toolTip1.SetToolTip(pbAddress2, "Open Work Address");

        }

    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
            try
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected == true)
                    {

                        txtID.Text = row.Cells[0].Value.ToString();

                    }
                }
                griddoldur2();
                dataGridView2.SelectAll();
                GetList();
              
            }
            catch
            {
                MessageBox.Show("Error!", "Fatal error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglan();
           
            try
            {
                using (con)
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = @"Delete from Veriler Where VeriID =" + txtID.Text;
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("VeriID", txtID.Text);


                        cmd.ExecuteReader();
                        con.Close();
                        dataGridView2.Rows.Clear();
                        griddoldur();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
                }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            dataGridView1.Rows.Clear();
            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString()+ "_database.db;Version=3;Password=" + password);
  
            con.Open();
            if (txtSearch.Text == "" && rdName.Checked == false && rdSurname.Checked == false && rdJob.Checked == false)
            {
                griddoldur();
            }
            if (rdName.Checked)
            { 
            SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Veriler where Name ='" + txtSearch.Text+"'",con);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("VeriID")),
            read.GetValue(read.GetOrdinal("Name")),
            read.GetValue(read.GetOrdinal("Surname"))
                       });
                    }
                }
            }
            else
                if(rdSurname.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Veriler where Surname ='" + txtSearch.Text + "'", con);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("VeriID")),
            read.GetValue(read.GetOrdinal("Name")),
            read.GetValue(read.GetOrdinal("Surname"))
                  });
                    }
                }

            }
            else
                if(rdJob.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Veriler where job ='" + txtSearch.Text + "'", con);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("VeriID")),
            read.GetValue(read.GetOrdinal("Name")),
            read.GetValue(read.GetOrdinal("Surname"))
                     });
                    }   
                }

            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                rdName.Checked = false;
                rdSurname.Checked = false;
                rdJob.Checked = false;
                

        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmNewRecord frm = new frmNewRecord();
            frm.VeriID = txtID.Text;
            frm.FillMyTextbox();
            frm.btnUpdate.Visible = true;
            frm.ShowDialog();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbAddress1_Click(object sender, EventArgs e)
        {
         System.Diagnostics.Process.Start("https://www.google.com/maps/search/"+txtHomeAddress.Text);
        }

        private void pbAddress2_Click(object sender, EventArgs e)
        {
          System.Diagnostics.Process.Start("https://www.google.com/maps/search/" + txtWorkAddressN.Text);
        }

        private void pbTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("twitter.com/" + txtTwitter.Text);

        }

        private void pbFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("facebook.com/" + txtFacebook.Text);

        }

        private void pbLinkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("linkedin.com/in/" + txtLinkedin.Text);

        }

        private void pbInstagram_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("instagram.com/"+txtInstagram.Text); 
        }

        private void pbWeb1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtWebSite1.Text);
            
        }

        private void pbWeb2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtWebSite2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void frmView_Resize(object sender, EventArgs e)
        {
            StringBuilder set1 = new StringBuilder(5000);
            StringBuilder set2 = new StringBuilder(5000);

            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");
            GetPrivateProfileString("Settings", "SysTray", "", set2, set2.Capacity, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            string durum = set2.ToString();
            if (durum== "True")
            { 
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = new Icon(Application.StartupPath + @"\data\images\LimeAppLogo.ico");
                notifyIcon1.Text = "LCM";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1, "Info", "LCM Running", ToolTipIcon.Info);
                notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            }
            }
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Activate();
        }
    }
}