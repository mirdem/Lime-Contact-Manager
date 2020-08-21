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
using System.Runtime.InteropServices;
namespace Lime_Contact_Manager
{
    public partial class frmBackup : Form
    {
        //private bool Kapatsorgu;
       // DialogResult dr = System.Windows.Forms.DialogResult.No;
        public frmBackup()
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
        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "DB|*.db";
            openfile.Title = "Select DB File";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                dbfile = openfile.FileName;
            }
        }
            string dbfile;
            string dbfilerestore;
            string dbsavefile;
      public  void inioku()
        {
        

        }


        private void btnSaveLoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "DB File|*.db";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                dbsavefile = save.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                timer2.Enabled = true;

                File.Copy(dbfile, dbsavefile);

            }
            catch (IOException ioExp)
            {
                MessageBox.Show("Backup Failed!" + ioExp, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "DB|*.db";
            openfile.Title = "Select DB File";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                dbfilerestore = openfile.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder set1 = new StringBuilder(5000);
                GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");
                string dbrestoresavefile = Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db";
                timer1.Enabled = true;

                File.Copy(dbfilerestore, dbrestoresavefile);
            }
             catch (IOException ioExp)
            {
                MessageBox.Show("Restore Failed!"+ ioExp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     

        private void frmBackup_Load(object sender, EventArgs e)
         {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            lblLoggedUser.Text = set1.ToString();
            lblDBFName.Text= set1.ToString() + "_database.db";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            timer1.Interval = 10;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                MessageBox.Show("Restore Complate.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            progressBar1.Value += 1;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            timer2.Interval = 10;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Enabled = false;
                MessageBox.Show("Backup Complate.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            progressBar1.Value += 1;

        }

        private void btnMain_Click(object sender, EventArgs e)
        {

            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmBackup_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmBackup_Resize(object sender, EventArgs e)
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
                    notifyIcon1.ShowBalloonTip(1, "Bilgi", "LCM Running", ToolTipIcon.Info);
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
