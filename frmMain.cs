using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;     
namespace Lime_Contact_Manager
{
    public partial class frmMain : Form
    {
        public frmMain()
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

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            frmNewRecord frmNewRecord = new frmNewRecord();
            this.Hide();
            frmNewRecord.Show();
        }

        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmView frmView = new frmView();
            frmView.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrint frmPrint = new frmPrint();
            frmPrint.Show();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBackup frmBackup = new frmBackup();
            frmBackup.Show();
        }

        private void btnEvents_Click(object sender, EventArgs e)
         {
             this.Hide();
            frmEvents frmEvents = new frmEvents();
            frmEvents.Show();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmContacts frmContacts = new frmContacts();
            frmContacts.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSendMail frmSendMail= new frmSendMail();
            frmSendMail.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSettings frmSettings = new frmSettings();
            frmSettings.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            StringBuilder set1 = new StringBuilder(5000);
            StringBuilder set2 = new StringBuilder(5000);
            StringBuilder set3 = new StringBuilder(5000);
            StringBuilder set4 = new StringBuilder(5000);
            StringBuilder set5 = new StringBuilder(5000);
            StringBuilder set6 = new StringBuilder(5000);
            StringBuilder set7 = new StringBuilder(5000);
            StringBuilder set8 = new StringBuilder(5000);
            StringBuilder set9 = new StringBuilder(5000);
            StringBuilder set10 = new StringBuilder(5000);
            StringBuilder set11 = new StringBuilder(5000);

            GetPrivateProfileString("Settings", "LoggedUser", "", set11, set11.Capacity, Application.StartupPath + "\\data\\db_settings.ini");


            //
            GetPrivateProfileString("Settings", "language", "", set1, set1.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "SysTray", "", set2, set2.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "NewRecord", "", set3, set3.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "ViewRecord", "", set4, set4.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "PrintExport", "", set5, set5.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "BackupRestore", "", set6, set6.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "Contacts", "", set7, set7.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "Events", "", set8, set8.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "SendMail", "", set9, set9.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");
            GetPrivateProfileString("Settings", "WinStarts", "", set10, set10.Capacity, Application.StartupPath + "\\data\\" + set11.ToString() + "_settings.ini");


            txtNewRecord.Text = set3.ToString();
            txtViewRecord.Text = set4.ToString();
            txtPrint.Text = set5.ToString();
            txtContact.Text = set7.ToString();
            txtEvents.Text = set8.ToString();
            txtSendMail.Text = set9.ToString();
            txtBackup.Text = set6.ToString();

         if(txtNewRecord.Text=="False")
            {
                btnNewRecord.Enabled = false;
            }
            if (txtViewRecord.Text == "False")
            {
                btnViewRecord.Enabled = false;
            }
            if (txtPrint.Text == "False")
            {
                btnExport.Enabled = false;
            }
            if (txtContact.Text == "False")
            {
                btnContacts.Enabled = false;
            }
            if (txtEvents.Text == "False")
            {
                btnEvents.Enabled = false;
            }
            if (txtSendMail.Text == "False")
            {
                btnSendMail.Enabled = false;
            }
            if (txtBackup.Text == "False")
            {
                btnBackup.Enabled = false;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            frmUpdates frmUpdates = new frmUpdates();
            frmUpdates.Show();
        }
    }
}
