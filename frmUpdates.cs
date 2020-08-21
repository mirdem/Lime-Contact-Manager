using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;

namespace Lime_Contact_Manager
{
    public partial class frmUpdates : Form
    {
        public frmUpdates()
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


        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            StringBuilder set1 = new StringBuilder(5000);
            StringBuilder set2= new StringBuilder(5000);

            GetPrivateProfileString("Update", "version", "", set1, set1.Capacity, Application.StartupPath + "\\data\\updates.ini");
            GetPrivateProfileString("Update", "url", "", set2, set2.Capacity, Application.StartupPath + "\\data\\updates.ini");

            string ServerVersion = set1.ToString();
            string InstalledVer = this.ProductVersion;
            string url = set2.ToString();
            label1.Text = set2.ToString();
            if(ServerVersion!=InstalledVer)
            {
                pbLCM.Visible = true;
                lblUpdateVer.Visible = true;
                lblUpdateVer.Text = "Updated Version: " + set1.ToString();
                if (MessageBox.Show("New update available Do you want to download now?", "Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(label1.Text);
                }
               
            }
            else
             if (ServerVersion == InstalledVer)
            {
                pbLCM.Visible = true;
                MessageBox.Show("No Updates available", "Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            pbLoading.Visible = false;
            lblChecking.Visible = false;

        }
        private void frmUpdates_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            lblInstalled.Text = "Installed Version: " + this.ProductVersion; ;
            pbLoading.Visible = true;
            lblChecking.Visible = true;
            pbLoading.Image = Image.FromFile(Application.StartupPath +@"\data\images\load.gif");
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            try
            { 
            WebClient client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri("https://xfdev.ucoz.net/LCM/updates.ini"), Application.StartupPath + @"\\data\\updates.ini");
            }
            catch(WebException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            pbLCM.Visible = false;
            pbLoading.Visible = true;
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
