using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Lime_Contact_Manager
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
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

        private void InitializeOpenFileDialog()
        {
            this.openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF;*.PNG|" +
               "All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Attachments";
            this.openFileDialog1.ShowDialog();
            lblAttachResult.Text = openFileDialog1.FileName;
        }

        private void InitializeOpenFileDialog2()
        {
            this.openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF;*.PNG|" +
               "All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Attachments";
            this.openFileDialog1.ShowDialog();
            lblAttachResult2.Text= openFileDialog1.FileName;
           
        }

        private void btnAttachments_Click(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
          
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="GMail")
            { 
            SmtpClient smtpGmail = new SmtpClient();
            smtpGmail.Host = "smtp.gmail.com";
            smtpGmail.Port = 587;
            smtpGmail.EnableSsl = true;
            smtpGmail.UseDefaultCredentials = false;
            smtpGmail.Credentials = new System.Net.NetworkCredential(txtMail.Text, txtPassword.Text);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(txtMail.Text, txtName.Text);
            mail.To.Add(txtReceiver.Text);
            mail.Subject =txtSubject.Text;
            mail.IsBodyHtml = true;
            mail.Body = txtBody.Text;
                if(lblAttachResult.Text!="")
                { 
                mail.Attachments.Add(new Attachment(lblAttachResult.Text));
                }
                else
                {

                }
                //   mail.Attachments.Add(new Attachment(lblAttachResult.Text));
                smtpGmail.Send(mail);           
            }
            else
                if(comboBox1.Text== "Outlook(Live.com)")
            {
                try
                { 
                SmtpClient smtpLive = new SmtpClient();
                smtpLive.Host = "smtp-mail.outlook.com";
                smtpLive.Port = 587;
                smtpLive.EnableSsl = true;
                smtpLive.Credentials = new System.Net.NetworkCredential(txtMail.Text, txtPassword.Text);
                MailMessage mailLive = new MailMessage();
                mailLive.From = new MailAddress(txtMail.Text, txtName.Text);
                mailLive.To.Add(txtReceiver.Text);
                mailLive.Subject = txtSubject.Text;
                mailLive.IsBodyHtml = true;
                mailLive.Body = txtBody.Text;
                    if (lblAttachResult.Text != "")
                    {
                        mailLive.Attachments.Add(new Attachment(lblAttachResult.Text));
                    }
                    else
                    {

                    }
                   // mailLive.Attachments.Add(new Attachment(lblAttachResult.Text));
           //     mailLive.Attachments.Add(new Attachment(lblAttachResult2.Text));
                smtpLive.Send(mailLive);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
                if(comboBox1.Text== "Yandex")
            {
                try
                { 
                SmtpClient smtpYandex = new SmtpClient();
                smtpYandex.Host = "smtp.yandex.com";
                smtpYandex.Port = 587;
                smtpYandex.EnableSsl = true;
                smtpYandex.Credentials = new System.Net.NetworkCredential(txtMail.Text, txtPassword.Text);
                MailMessage mailYandex = new MailMessage();
                mailYandex.From = new MailAddress(txtMail.Text, txtName.Text);
                mailYandex.To.Add(txtReceiver.Text);
                mailYandex.Subject = txtSubject.Text;
                mailYandex.IsBodyHtml = true;
                mailYandex.Body = txtBody.Text;
                    if (lblAttachResult.Text != "")
                    {
                        mailYandex.Attachments.Add(new Attachment(lblAttachResult.Text));
                    }
                    else
                    {

                    }
                  //  mailYandex.Attachments.Add(new Attachment(lblAttachResult.Text));
              //  mailYandex.Attachments.Add(new Attachment(lblAttachResult2.Text));
                smtpYandex.Send(mailYandex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
        }

        private void btnAttachments2_Click(object sender, EventArgs e)
        {
            InitializeOpenFileDialog2();

        }

        private void frmSendMail_Load(object sender, EventArgs e)
        {

            if (comboBox1.Text== "GMail")
            {
                pbGmailWarn.Visible = true;
            }
            else
                pbGmailWarn.Visible = false;

            this.toolTip1.SetToolTip(pbGmailWarn, "Please Click for More Information.");
            txtMail.Text = Properties.Settings.Default.UserMailAdd;
            txtPassword.Text = Properties.Settings.Default.UserMailPass;
            txtName.Text = Properties.Settings.Default.UserMailName;
            comboBox1.Text = Properties.Settings.Default.UserMailService;
        }

        private void pbGmailWarn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://myaccount.google.com/lesssecureapps");
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "GMail")
            {
                pbGmailWarn.Visible = true;
            }
            else
                pbGmailWarn.Visible = false;
        }

        private void frmSendMail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

        }

        private void frmSendMail_Resize(object sender, EventArgs e)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }
    }
}
