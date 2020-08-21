using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SQLite;
namespace Lime_Contact_Manager
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private static string password = "194553";

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\Users_database.db;Version=3;Password=" + password);

                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("Select * From Kullanicilar where Email='" + txtMail.Text + "'", con);
                SQLiteDataReader dr = cmd.ExecuteReader();
                bool parola_Verildimi = false;
                while (dr.Read())
                {
                    try
                    {
                        SmtpClient smtpserver = new SmtpClient();
                        MailMessage mail = new MailMessage();

                        String mailadresin = ("xfdevapps@gmail.com");
                        String mailsifren = ("QPwj44LsyV"); 
                        String smptsrvr = "smtp.gmail.com";
                        String kime = (dr["EMail"].ToString());
                        String konu = ("Parola Hatırlatma");
                        String yazi = ("Sayın " + dr["Username"].ToString() + "\nParolanız: " + dr["Password"].ToString());

                        smtpserver.Credentials = new NetworkCredential(mailadresin, mailsifren);
                        smtpserver.Port = 587;
                        smtpserver.Host = smptsrvr;
                        smtpserver.EnableSsl = true;
                        mail.From = new MailAddress(mailadresin);
                        mail.To.Add(kime);
                        mail.Subject = konu;
                        mail.Body = yazi;
                        smtpserver.Send(mail);
                        MessageBox.Show("Login to your account with a password sent to your mail.\nFor your security, please change your password..");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    parola_Verildimi = true;

                    if (parola_Verildimi)
                    {
                        this.Close();
                    }
                }
                if (parola_Verildimi == false)
                {
                    MessageBox.Show("Please check the information you entered!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                this.Close();
            }
        }

        private void frmForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}
