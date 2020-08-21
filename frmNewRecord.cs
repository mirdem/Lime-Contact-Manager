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
    public partial class frmNewRecord : Form
    {
        public frmNewRecord()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        public SQLiteConnection con = null;
        private static string password = "194553";
        public string VeriID { get; set; }
        NotifyIcon MyIcon = new NotifyIcon();

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

        public void FillMyTextbox()
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            string constr = "Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password;

            using (SQLiteConnection con = new SQLiteConnection(constr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT Name, Surname, birthday, homephone, mobilephone, workphone, faxnumber, homeaddress, workaddress, job, email1, email2, website1, website2, twitter, facebook, linkedin, instagram, notes FROM Veriler WHERE VeriID=" + VeriID))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SQLiteDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        txtName.Text = sdr["Name"].ToString();
                        txtSurname.Text = sdr["Surname"].ToString();
                        txtBirthday.Text = sdr["birthday"].ToString();
                        txtHomePhone.Text = sdr["homephone"].ToString();
                        txtMobPhone.Text = sdr["mobilephone"].ToString();
                        txtWorkPhone.Text = sdr["workphone"].ToString();
                        txtFaxNumber.Text = sdr["faxnumber"].ToString();
                        txtHomeAddress.Text = sdr["homeaddress"].ToString();
                        txtWorkAddress.Text = sdr["workaddress"].ToString();
                        txtJob.Text = sdr["job"].ToString();
                        txtEMail1.Text = sdr["email1"].ToString();
                        txtEMail2.Text = sdr["email2"].ToString();
                        txtWebsite1.Text = sdr["website1"].ToString();
                        txtWebsite2.Text = sdr["website2"].ToString();
                        txtTwitter.Text = sdr["twitter"].ToString();
                        txtFacebook.Text = sdr["facebook"].ToString();
                        txtLinkedin.Text = sdr["linkedin"].ToString();
                        txtInstagram.Text = sdr["instagram"].ToString();
                        txtNotes.Text = sdr["notes"].ToString();
                    }
                    con.Close();
                }
            }
        }

        public void KisiAdressGuncelle()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = new SQLiteCommand();
            baglan();
            cmd.Connection = con;
            cmd.CommandText = "update Veriler set Name='" + txtName.Text + "',Surname='" + txtSurname.Text + "',birthday='" + txtBirthday.Text + "',homephone='" + txtHomePhone.Text + "',mobilephone='" + txtMobPhone.Text + "',workphone='" + txtWorkPhone.Text + "',faxnumber='" + txtFaxNumber.Text + "',homeaddress='" + txtHomeAddress.Text + "',workaddress='" + txtWorkAddress.Text + "',job='" + txtJob.Text + "',email1='" + txtEMail1.Text + "',email2='" + txtEMail2.Text + "',website1='" + txtWebsite1.Text + "',website2='" + txtWebsite2.Text + "',twitter='" + txtTwitter.Text + "',facebook='" + txtFacebook.Text + "',linkedin='" + txtLinkedin.Text + "',instagram='" + txtInstagram.Text + "',notes='" + txtNotes.Text + "' where VeriID=" + VeriID + "";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update complate.", "Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void baglan()
        {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password);
            con.Open();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.txtBirthday.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

                        cmd.CommandText = "insert into Veriler (Name, Surname, birthday, homephone, mobilephone, workphone, faxnumber, homeaddress, workaddress, job, email1, email2, website1, website2, twitter, facebook, linkedin, instagram, notes) Values (@Name, @Surname, @birthday, @homephone, @mobilephone, @workphone, @faxnumber, @homeaddress, @workaddress, @job, @email1, @email2, @website1, @website2, @twitter, @facebook, @linkedin, @instagram, @notes)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("Name", txtName.Text);
                        cmd.Parameters.AddWithValue("Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("birthday", txtBirthday.Text);
                        cmd.Parameters.AddWithValue("homephone", txtHomePhone.Text);
                        cmd.Parameters.AddWithValue("mobilephone", txtMobPhone.Text);
                        cmd.Parameters.AddWithValue("workphone", txtWorkPhone.Text);
                        cmd.Parameters.AddWithValue("faxnumber", txtFaxNumber.Text);
                        cmd.Parameters.AddWithValue("homeaddress", txtHomeAddress.Text);
                        cmd.Parameters.AddWithValue("workaddress", txtWorkAddress.Text);
                        cmd.Parameters.AddWithValue("job", txtJob.Text);
                        cmd.Parameters.AddWithValue("email1", txtEMail1.Text);
                        cmd.Parameters.AddWithValue("email2", txtEMail2.Text);
                        cmd.Parameters.AddWithValue("website1", txtWebsite1.Text);
                        cmd.Parameters.AddWithValue("website2", txtWebsite2.Text);
                        cmd.Parameters.AddWithValue("twitter", txtTwitter.Text);
                        cmd.Parameters.AddWithValue("facebook", txtFacebook.Text);
                        cmd.Parameters.AddWithValue("linkedin", txtLinkedin.Text);
                        cmd.Parameters.AddWithValue("instagram", txtInstagram.Text);
                        cmd.Parameters.AddWithValue("notes", txtNotes.Text);
                        cmd.ExecuteNonQuery();

                        lastId = (int)con.LastInsertRowId;
                        transaction.Commit();
                    }

                    MessageBox.Show("Contact added.", "LCM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void frmNewRecord_Load(object sender, EventArgs e)
        { 
            Properties.Settings.Default.VeriID = VeriID;
            this.toolTip1.SetToolTip(pbMail1, "Send Mail (1)");
            this.toolTip1.SetToolTip(pbMail2, "Send Mail (2)");
            this.toolTip1.SetToolTip(pbTwitter, "Open Twitter");
            this.toolTip1.SetToolTip(pbFacebook, "Open Facebook");
            this.toolTip1.SetToolTip(pbLinkedin, "Open Linkedin");
            this.toolTip1.SetToolTip(pbInstagram, "Open Instagram");
            this.toolTip1.SetToolTip(pbWebsite1, "Open Website (1)");
            this.toolTip1.SetToolTip(pbWebsite2, "Open Website (2)");
            this.toolTip1.SetToolTip(pbAddress1, "Open Home Address");
            this.toolTip1.SetToolTip(pbAddress2, "Open Work Address");

            this.toolTip1.SetToolTip(pictureBox1, "Add Contacts");
            this.toolTip1.SetToolTip(pictureBox2, "Add Contacts");
            this.toolTip1.SetToolTip(pictureBox3, "Add Contacts");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            KisiAdressGuncelle();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
        }

        private void frmNewRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmNewRecord_Resize(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
                        cmd.Parameters.AddWithValue("number", txtHomePhone.Text);
                        cmd.ExecuteNonQuery();

                        lastId = (int)con.LastInsertRowId;
                        transaction.Commit();
                    }
                    if (MessageBox.Show("Contact added, View?", "Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmContacts frmContacts = new frmContacts();
                        this.Hide();
                        frmContacts.Show();
                    }


                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
                        cmd.Parameters.AddWithValue("number", txtMobPhone.Text);
                        cmd.ExecuteNonQuery();

                        lastId = (int)con.LastInsertRowId;
                        transaction.Commit();
                    }
                    if (MessageBox.Show("Contact added, View?", "Delete DB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmContacts frmContacts = new frmContacts();
                        this.Hide();
                        frmContacts.Show();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
                        cmd.Parameters.AddWithValue("number", txtWorkPhone.Text);
                        cmd.ExecuteNonQuery();

                        lastId = (int)con.LastInsertRowId;
                        transaction.Commit();
                    }
                    if (MessageBox.Show("Contact added, View?", "Delete DB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmContacts frmContacts = new frmContacts();
                        this.Hide();
                        frmContacts.Show();
                    }
                }
            }
        }

        private void pbMail1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:" + txtEMail1.Text);
            }
            catch
            {

            }
        }

        private void pbMail2_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("mailto:"+txtEMail2.Text);
            }
            catch
            {

            }
        }

        private void pbWebsite1_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start(txtWebsite1.Text);
            }
            catch
            {

            }
        }

        private void pbWebsite2_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start(txtWebsite2.Text);
            }
            catch
            {

            }
        }

        private void pbTwitter_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("https://twitter.com/" + txtTwitter.Text);
            }
            catch
            {

            }
        }

        private void pbFacebook_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("https://facebook.com/" + txtFacebook.Text);
            }
            catch
            {

            }
        }

        private void pbLinkedin_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/" + txtLinkedin.Text);
            }
            catch
            {

            }
        }

        private void pbInstagram_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/" + txtInstagram.Text);
            }
            catch
            {

            }
        }

        private void pbAddress1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.google.com/maps/search/" + txtHomeAddress.Text);
            }
            catch
            {

            }

        }

        private void pbAddress2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.google.com/maps/search/" + txtWorkAddress.Text);
            }
            catch
            {

            }
        }
    }
}
