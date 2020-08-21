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
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private static string password = "194553";
        SQLiteConnection con = new SQLiteConnection();
        string IDTut;

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

        void baglan()
        {
            dataGridView1.Rows.Clear();
            StringBuilder set1 = new StringBuilder(5000);
            SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password);
            con.Open();
        }

        public void KisiAdressGuncelle()
        { SQLiteCommand cmd = new SQLiteCommand();
            cmd = new SQLiteCommand();
            baglan();
            cmd.Connection = con;
            cmd.CommandText = "update Rehber set Name='" + txtName.Text + "',Surname='" + txtSurname.Text + "',number='" + txtPhone.Text + "' where RehberID=" + lblID.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        void griddoldur()
        {
            dataGridView1.Rows.Clear();
            StringBuilder set1 = new StringBuilder(5000);

            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Rehber", con);
           
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("RehberID")),
            read.GetValue(read.GetOrdinal("Name")),
            read.GetValue(read.GetOrdinal("Surname")),
            read.GetValue(read.GetOrdinal("number"))
     });
                }
            }
        }

        void FillMyTextbox()
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            string constr = "Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password;

            using (SQLiteConnection con = new SQLiteConnection(constr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT RehberID, Name, Surname, number FROM Rehber WHERE RehberID=" + lblID.Text))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SQLiteDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        lblID.Text = sdr["RehberID"].ToString();
                        txtName.Text = sdr["Name"].ToString();
                        txtSurname.Text = sdr["Surname"].ToString();
                        txtPhone.Text = sdr["number"].ToString();
                    }
                    con.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            dataGridView1.Rows.Clear();
            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" +set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
            if (txtSearch.Text == "" && rdName.Checked == false && rdSurname.Checked == false)
            {
                griddoldur();
            }
            if (rdName.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Rehber where Name ='" + txtSearch.Text + "'", con);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("RehberID")),
            read.GetValue(read.GetOrdinal("Name")),
            read.GetValue(read.GetOrdinal("Surname")),
            read.GetValue(read.GetOrdinal("number"))
                       });
                    }
                }
            }
            else
                if (rdSurname.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Rehber where Surname ='" + txtSearch.Text + "'", con);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("RehberID")),
            read.GetValue(read.GetOrdinal("Name")),
            read.GetValue(read.GetOrdinal("Surname")),
            read.GetValue(read.GetOrdinal("number"))
                  });
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                int lastId = -1;
                baglan();
                using (con)
                {

                    using (SQLiteCommand cmd = new SQLiteCommand(con))
                    {
                        SQLiteTransaction transaction = null;
                        transaction = con.BeginTransaction();

                        cmd.CommandText = "insert into Rehber (Name, Surname, number) Values (@Name, @Surname, @number)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("Name", txtName.Text);
                        cmd.Parameters.AddWithValue("Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("number", txtPhone.Text);
                        cmd.ExecuteNonQuery();

                        lastId = (int)con.LastInsertRowId;
                        transaction.Commit();
                    }
                    MessageBox.Show("Contact added.", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    griddoldur();
                }
            }
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            griddoldur();
            


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            rdName.Checked = false;
            rdSurname.Checked = false;
          
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                IDTut = selectedRow.Cells[0].Value.ToString();
                lblID.Text=selectedRow.Cells[0].Value.ToString();
                FillMyTextbox();
            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            KisiAdressGuncelle();
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
                        cmd.CommandText = @"Delete from Rehber Where RehberID =" + lblID.Text;
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("VeriID", lblID.Text);


                        cmd.ExecuteReader();
                        con.Close();
                        dataGridView1.Rows.Clear();
                        griddoldur();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmContacts_Resize(object sender, EventArgs e)
        {

            StringBuilder set1 = new StringBuilder(5000);
            StringBuilder set2 = new StringBuilder(5000);

            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");
            GetPrivateProfileString("Settings", "SysTray", "", set2, set2.Capacity, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            string durum = set2.ToString();
            if (durum == "True")
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
