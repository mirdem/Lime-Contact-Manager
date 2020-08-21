using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace Lime_Contact_Manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public string password = "194553";

        public static long FolderSizeCalculation(string yol)
        {
            long size = 0;
            string[] folders = Directory.GetFiles(yol, "*.*", SearchOption.AllDirectories);
            foreach (string folder in folders)
            {
                FileInfo fileInfo = new FileInfo(folder);
                size += fileInfo.Length;
            }
            return size;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.LoggedAs;
            if(checkBox1.Checked)
            {
                StringBuilder set1 = new StringBuilder(5000);
                GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");
                txtUsername.Text = set1.ToString();

            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long dosyaninByteCinsindenBoyutu = FolderSizeCalculation(Application.StartupPath+"\\data\\databases\\");
            lblSize.Text= dosyaninByteCinsindenBoyutu.ToString();

            if(lblSize.Text=="0")
            {
                this.Hide();
                frmSetupDB frmSetupDB = new frmSetupDB();
                frmSetupDB.Show();
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            WriteINI("Settings", "LoggedUser", txtUsername.Text, Application.StartupPath + "\\data\\db_settings.ini");
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\Users_database.db;Version=3;Password=" + password);
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Kullanicilar where Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.Hide();

                frmMain frmMain = new frmMain();
                frmMain.Show();

            }
            else
            {
                if (MessageBox.Show("Login failed, check username and password or haven't added user yet?", "Login Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    this.Hide();

                    frmSetupDB frmSetupDB = new frmSetupDB();
                    frmSetupDB.Show();
                }
                con.Close();
                con.Dispose();
                Properties.Settings.Default.UserNames = txtUsername.Text;
                Properties.Settings.Default.Pass = txtPassword.Text;
                Properties.Settings.Default.Save();
               
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetupDB frmSetupDB = new frmSetupDB();
            frmSetupDB.Show();
            timer1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LoggedAs= checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            frmForgotPassword.Show();
        }
    }
}
