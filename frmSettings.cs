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
using System.IO;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace Lime_Contact_Manager
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        string ProgramAdi = "Lime Contact Manager";
        public string password = "194553";

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

        private void settingsOku()
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

            cbxLang.Text = set1.ToString();
            txtSysTray.Text = set2.ToString();
            txtNewRecord.Text = set3.ToString();
            txtViews.Text = set4.ToString();
            txtPrint.Text = set5.ToString();
            txtBackup.Text = set6.ToString();
            txtContacts.Text = set7.ToString();
            txtEvents.Text = set8.ToString();
            txtSendMail.Text = set9.ToString();
            txtWinStarts.Text = set10.ToString();

            if (txtSysTray.Text == "True")
            {
                chxMinimizeTray.Checked = true;
            }
            else
                chxMinimizeTray.Checked = false;

            if (txtNewRecord.Text == "True")
            {
                checkBox1.Checked = true;
            }
            else
                checkBox1.Checked = false;

            if (txtViews.Text == "True")
            {
                checkBox2.Checked = true;
            }
            else
                checkBox2.Checked = false;
            //
            if (txtPrint.Text == "True")
            {
                checkBox3.Checked = true;
            }
            else
                checkBox3.Checked = false;

            if (txtBackup.Text == "True")
            {
                checkBox4.Checked = true;
            }
            else
                checkBox4.Checked = false;

            if (txtContacts.Text == "True")
            {
                checkBox5.Checked = true;
            }
            else
                checkBox5.Checked = false;

            if (txtEvents.Text == "True")
            {
                checkBox6.Checked = true;
            }
            else
                checkBox6.Checked = false;

            if (txtSendMail.Text == "True")
            {
                checkBox7.Checked = true;
            }
            else
                checkBox7.Checked = false;

            if (txtWinStarts.Text == "True")
            {
                chxStartsWin.Checked = true;
            }
            else
                chxStartsWin.Checked = false;

        }

        void checkStarts()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue(ProgramAdi).ToString() == "\"" + Application.ExecutablePath + "\"")
                { // Eğer regeditte varsa, checkbox ı işaretle
                    chxStartsWin.Checked = true;
                }
            }
            catch
            {

            }
        }
        private void chxStartsWin_CheckedChanged(object sender, EventArgs e)
        {
            if (chxStartsWin.Checked)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
                txtWinStarts.Text = "True";
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(ProgramAdi);
                txtWinStarts.Text = "False";
            }
        }

        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmSettings_Resize(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            WriteINI("Settings", "language", cbxLang.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "SysTray", txtSysTray.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "NewRecord", txtNewRecord.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "ViewRecord", txtViews.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "PrintExport", txtPrint.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "BackupRestore", txtBackup.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "Contacts", txtContacts.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "Events", txtEvents.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "SendMail", txtSendMail.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            WriteINI("Settings", "WinStarts", txtWinStarts.Text, Application.StartupPath + "\\data\\" + set1.ToString() + "_settings.ini");
            MessageBox.Show("All settings saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtNewRecord.Text = checkBox1.Checked.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtViews.Text = checkBox2.Checked.ToString();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtPrint.Text = checkBox3.Checked.ToString();

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            txtBackup.Text = checkBox4.Checked.ToString();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            txtContacts.Text = checkBox5.Checked.ToString();

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            txtEvents.Text = checkBox6.Checked.ToString();

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            txtSendMail.Text = checkBox7.Checked.ToString();

        }

        private void chxMinimizeTray_CheckedChanged(object sender, EventArgs e)
        {
            txtSysTray.Text = chxMinimizeTray.Checked.ToString();

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            settingsOku();
        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Attention! This process deletes all your data and you will never be able to return your data at the end of this process. Do you want to continue?", "Delete DB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\LCM DB Connector.exe");
                Environment.Exit(0);
            }
        }
    }
}
