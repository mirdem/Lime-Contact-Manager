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
using System.IO;
namespace Lime_Contact_Manager
{
    public partial class frmSetupDB : Form
    {
        public frmSetupDB()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        public SQLiteConnection con = null;
        private static string password = "194553";

        void baglan()
        {
            con = new SQLiteConnection("Data Source="+Application.StartupPath+"\\data\\databases\\" +txtUserName.Text+ "_database.db;Version=3;Password=" +password);
            con.Open();
        }
        void baglanUsers()
        {
            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\Users_database.db;Version=3;Password=" + password);
            con.Open();
        }
        public void TabloOlusturEtkinlikler()
        {
            baglan();
            using (con)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = @"Create table if not exists Events (
            EventID INTEGER PRIMARY KEY AUTOINCREMENT, 
            EventName varchar(55), 
            EventNote varchar(55),	
			EventDate text)";

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        //
        public void TabloOlusturRehber()
        {
            baglan();
            using (con)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = @"Create table if not exists Rehber (
            RehberID INTEGER PRIMARY KEY AUTOINCREMENT, 
            Name varchar(55), 
            Surname varchar(55),	
			number numeric)";

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        //
            public void TabloOlusturVeriler()
        {
            baglan();
            using (con)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = @"Create table if not exists Veriler (
            VeriID INTEGER PRIMARY KEY AUTOINCREMENT, 
            Name varchar(55), 
            Surname varchar(55),
			birthday text,
            homephone varchar(55),
			mobilephone varchar(55),
			workphone varchar(55),
			faxnumber varchar(55),
			homeaddress varchar(150),
			workaddress varchar(150),
			job varchar(55),
			email1 varchar(50),
			email2 varchar(50),
			website1 varchar(50),
			website2 varchar(50),
			twitter varchar(50),
			facebook varchar(50), 
			linkedin varchar(50),
			instagram varchar(50),
            notes varchar(250),
			images bloob)";

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        //
        public void TabloOlustur()
        {
            baglanUsers();
            using (con)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(con))
                {

                    cmd.CommandText = @"Create table if not exists Kullanicilar (
            UserID INTEGER PRIMARY KEY AUTOINCREMENT, 
            Username varchar(55), 
            Password varchar(55),
            Email varchar(55))";

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void TabloOlusturSerial()
        {
            baglanUsers();
            using (con)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(con))
                {

                    cmd.CommandText = @"Create table if not exists Serial (
            SerialID INTEGER PRIMARY KEY AUTOINCREMENT, 
            FirstRunDate varchar(55), 
            EndRunDate varchar(55),
            serial varchar(55))";

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        void verileriEkle()
        {
            {
                int lastId = -1;
                baglanUsers();
                using (con)
                {

                    using (SQLiteCommand cmd = new SQLiteCommand(con))
                    {
                        SQLiteTransaction transaction = null;
                        transaction = con.BeginTransaction();

                        cmd.CommandText = "insert into Serial (FirstRunDate, EndRunDate, serial) Values (@FirstRunDate, @EndRunDate, @serial)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("FirstRunDate", "0");
                        cmd.Parameters.AddWithValue("EndRunDate", "0");
                        cmd.Parameters.AddWithValue("serial", "0");
                        cmd.ExecuteNonQuery();

                        lastId = (int)con.LastInsertRowId;
                        transaction.Commit();
                    }


                }
            }
        }

        //
        private void frmSetupDB_Load(object sender, EventArgs e)
        {
            txtUserName.MaxLength = 20;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                btnNextWelcome.Enabled = false;
                txtUserName.BackColor = Color.Red;
            }
            else
            { 
                btnNextWelcome.Enabled = true;
                txtUserName.BackColor = Color.White;

            }
        }

        private void btnNextWelcome_Click(object sender, EventArgs e)
        {
            grbLoginInfo.Visible = true;
            grbLoginInfo.Location = new Point(12, 12);
            grbWelcome.Location= new Point(496,12);
            grbWelcome.Visible = false;
            grbSummary.Visible = false;    
        }

        private void btnBackInfos_Click(object sender, EventArgs e)
        {
            grbWelcome.Visible = true;
            grbWelcome.Location = new Point(12,12) ;
            grbLoginInfo.Location = new Point(496, 12);
            grbSummary.Visible = false;
            grbLoginInfo.Visible = false;
        }

        private void btnNextInfos_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="")
            {
                MessageBox.Show("Please check the information you entered and try again.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please check the information you entered and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (txtEMail.Text == "")
            {
                MessageBox.Show("Please check the information you entered and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            grbSummary.Visible = true;
            grbSummary.Location = new Point(12,12);
            grbLoginInfo.Location = new Point(496,12);
            grbWelcome.Visible = false;
            grbLoginInfo.Visible = false;
            lblSumUserName.Text ="Username: "+ txtUserName.Text;
            lblPassSum.Text = "Password: "+txtPassword.Text;
            lblMailSum.Text ="E-Mail: "+ txtEMail.Text;
            }
        }

        private void btnBackSummary_Click(object sender, EventArgs e)
        {
            grbLoginInfo.Visible = true;
            grbLoginInfo.Location = new Point(12, 12);
            grbSummary.Location = new Point(496, 12);
            grbSummary.Visible = false;
            grbWelcome.Visible = false;
        }

        private void btnSaveFinish_Click(object sender, EventArgs e)
        {


            if (!File.Exists (Application.StartupPath + "\\data\\databases\\" + txtUserName.Text + "_database.db"))
            {

                SQLiteConnection.CreateFile(Application.StartupPath + "\\data\\databases\\" + txtUserName.Text + "_database.db");
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + (Application.StartupPath + "\\data\\databases\\" + txtUserName.Text + "_database.db" + ";Version=3;"));
                conn.Open();
                
                conn.ChangePassword(password);

            }

            if (!File.Exists(Application.StartupPath + "\\data\\databases\\Users_database.db"))
            {
                SQLiteConnection.CreateFile(Application.StartupPath + "\\data\\databases\\Users_database.db");
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + (Application.StartupPath + "\\data\\databases\\Users_database.db"));
                conn.Open();
                conn.ChangePassword(password);

            }

            TabloOlustur();
            TabloOlusturSerial();
            TabloOlusturVeriler();
            TabloOlusturEtkinlikler();
            TabloOlusturRehber();
           
            {
                int lastId = -1;
                baglanUsers();
                using (con)
                {

                    using (SQLiteCommand cmd = new SQLiteCommand(con))
                    {
                        SQLiteTransaction transaction = null;
                        transaction = con.BeginTransaction();

                        cmd.CommandText = "insert into Kullanicilar (Username, Password, Email) Values (@Username, @Password, @Email)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("Username", txtUserName.Text);
                        cmd.Parameters.AddWithValue("Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("Email", txtEMail.Text);
                        cmd.ExecuteNonQuery();

                        lastId = (int)con.LastInsertRowId;
                        transaction.Commit();
                        MessageBox.Show("The user has been successfully added. You can login now.", "Setup Complete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        frmLogin frmLogin = new frmLogin();
                        this.Hide();
                        frmLogin.Show();
                        //File.Move(Application.StartupPath+ "\\data\\Key_LcmSerials.db", Application.StartupPath + "\\data\\databases\\Key_LcmSerials.db");
                    }
                    verileriEkle();
                }
                
             }
        }

        private void frmSetupDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
