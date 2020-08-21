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
using System.Net;
using Microsoft.Win32;
using System.IO;
namespace Lime_Contact_Manager
{
    public partial class frmSerialCheck : Form
    {
        public frmSerialCheck()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        SQLiteConnection con = new SQLiteConnection();
        WebClient client = new WebClient();

        public string password = "194553";
        public string passwordKey = "UvRn6DfgM8aSy7ub";
        void baglan()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + Properties.Settings.Default.UserName + "_database.db;Version=3;Password=" + passwordKey);

            con.Open();
        }
        void baglan2()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\Users_database.db;Version=3;Password=" + password);

            con.Open();
        }
        void TarihYaz()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\LCM");


            string aDate = DateTime.Now.ToString("dd.MM.yyy");
            string trialend = dateTimePicker1.Value.AddDays(30).ToString();

            //   string trialend = DateTime.Now.AddDays(30).ToString();
            if(key==null)
            { 
            key.SetValue("TrialStart", aDate);
            key.SetValue("TrialEnd", trialend.ToString());
            key.Close();
            }
        }

        void TarihOku()
        {
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LCM");
            lblExpDate.Text = (key2.GetValue("TrialEnd").ToString());
            key2.Close();

            if (lblNowDate.Text == lblExpDate.Text)
            {
                MessageBox.Show("The trial version has ended. Please purchase the program.", "Trial Expired", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void GuncelTarih()
        {
            string aDate = DateTime.Now.ToString("dd.MM.yyy");
            lblNowDate.Text = aDate.ToString();
        }

        void GetSerials()
        {
            lblHideSerial.Text = "";
            lblHideMail.Text = "";

            SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\Key_LcmSerials.db;Version=3;Password=" + passwordKey);

            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("Select * From KEYS where keyADI='" + txtLicence.Text + "'", con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string GirilenLisans = (dr["keyADI"].ToString());
                string GirilenMail = (dr["OwnerMail"].ToString());
                lblHideSerial.Text = GirilenLisans.ToString();
                lblHideMail.Text = GirilenMail.ToString();
            
            }
        }

    

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


        private void frmSerialCheck_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            GuncelTarih();
          //  TarihYaz();
          lblHideSerial.Text = "";
          lblHideMail.Text = "";
          timerTarihOku.Enabled = true;
      //    timerDiskCheck.Enabled = true;
      //  timer1.Enabled = true; 
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(txtLicence.Text=="" && txtEMail.Text=="")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.");
            }
            if (lblHideSerial.Text == null && lblHideMail.Text == null)
            {
                MessageBox.Show("The information you entered is invalid. Please try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (lblHideSerial.Text!="" && lblHideMail.Text!= "")
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\LCM Licence");

                key.SetValue("Key", txtLicence.Text);
                key.SetValue("OwnerMail", txtEMail.Text);
                key.Close();
                lblSavedKeyShow.Text = txtLicence.Text;
                lblSavedMailShow.Text = txtEMail.Text;
                Properties.Settings.Default.LisansKontrolEt = "True";
                MessageBox.Show("The license has been successfully activated, thanks for your purchase.", "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin frmLogin = new frmLogin();
                 this.Hide();
                frmLogin.Show();
            }

        }

        private void txtLicence_TextChanged(object sender, EventArgs e)
        {
            GetSerials();
            if (txtLicence.Text == "" && txtEMail.Text == "")
            {
                btnApply.Enabled = false;
            }
        }

        private void frmSerialCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (txtDurum.Text == "True")
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                timer1.Enabled = false;
            }
            if (txtDurum.Text == "False")
            {
                timer1.Enabled = false;

                MessageBox.Show("The trial version has ended. Please purchase the program.", "Trial Expired", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timerDiskCheck_Tick(object sender, EventArgs e)
        {
            txtDurum.Text = Properties.Settings.Default.LisansKontrolEt.ToString();

            long dosyaninByteCinsindenBoyutu = FolderSizeCalculation(Application.StartupPath + "\\data\\databases\\");
            lblSize.Text = dosyaninByteCinsindenBoyutu.ToString();

            if (lblSize.Text == "0")
            {
                this.Hide();
                frmSetupDB frmSetupDB = new frmSetupDB();
                frmSetupDB.Show();
                timerDiskCheck.Enabled = false;
            }
            else
            {
                timerDiskCheck.Enabled = false;
            }
        }

        private void timerTarihOku_Tick(object sender, EventArgs e)
        {
            TarihYaz();

             TarihOku();
            timerTarihOku.Enabled = false;
        }
    }
}

