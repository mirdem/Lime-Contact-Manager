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
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private static string password = "194553";
        SQLiteConnection con = new SQLiteConnection();

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
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
        }

        void griddoldur()
        {
            dataGridView1.Rows.Clear();
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");


            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Events", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("EventID")),
            read.GetValue(read.GetOrdinal("EventName")),
            read.GetValue(read.GetOrdinal("EventNote")),
             read.GetValue(read.GetOrdinal("EventDate"))
     });
                }
            }
        }
       
        public void KisiAdressGuncelle()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = new SQLiteCommand();
            baglan();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Events SET EventID ="+ "'"+txtID.Text+"',"+ "EventName =" +"'"+txtEventName.Text+"',"+" EventNote ="+ "'"+txtNote.Text+"',"+ "EventDate ="+ "'"+txtDate.Text+"'"+"WHERE EventID ="+ txtID.Text; ;
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
        private void frmEvents_Load(object sender, EventArgs e)
        {
            griddoldur();
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            txtID.Text = "1";
            txtDate.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmEvents_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglan();

            try
            {
                using (con)
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = @"Delete from Events Where EventID =" + txtID.Text;
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("EventID", txtID.Text);
                        cmd.ExecuteReader();
                        con.Close();
                        griddoldur();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   
                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                
            }
            catch
            {

            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            KisiAdressGuncelle();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void frmEvents_Resize(object sender, EventArgs e)
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

                        cmd.CommandText = "insert into Events (EventName, EventNote, EventDate) Values (@EventName, @EventNote, @EventDate)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("EventName", txtEventName.Text);
                        cmd.Parameters.AddWithValue("EventNote", txtNote.Text);
                        cmd.Parameters.AddWithValue("EventDate", txtDate.Text);
                        cmd.ExecuteNonQuery();

                        lastId = (int)con.LastInsertRowId;
                        transaction.Commit();
                    }
                    MessageBox.Show("Event added.", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    griddoldur();
                }
            }
        }
    }
}

