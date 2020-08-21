namespace Lime_Contact_Manager
{
    partial class frmSendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendMail));
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAttachments = new System.Windows.Forms.Button();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAttachments2 = new System.Windows.Forms.Button();
            this.lblAttachResult2 = new System.Windows.Forms.Label();
            this.lblAttachResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbGmailWarn = new System.Windows.Forms.PictureBox();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGmailWarn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(359, 508);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAttachments
            // 
            this.btnAttachments.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAttachments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachments.Location = new System.Drawing.Point(84, 482);
            this.btnAttachments.Name = "btnAttachments";
            this.btnAttachments.Size = new System.Drawing.Size(75, 23);
            this.btnAttachments.TabIndex = 1;
            this.btnAttachments.Text = "Select";
            this.btnAttachments.UseVisualStyleBackColor = true;
            this.btnAttachments.Click += new System.EventHandler(this.btnAttachments_Click);
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(81, 33);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 21);
            this.txtSender.TabIndex = 2;
            this.txtSender.Visible = false;
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(81, 73);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(100, 21);
            this.txtReceiver.TabIndex = 3;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(81, 110);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 21);
            this.txtSubject.TabIndex = 5;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(81, 243);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(353, 232);
            this.txtBody.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAttachments2);
            this.groupBox1.Controls.Add(this.lblAttachResult2);
            this.groupBox1.Controls.Add(this.lblAttachResult);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblSender);
            this.groupBox1.Controls.Add(this.lblReceiver);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.lblBody);
            this.groupBox1.Controls.Add(this.lblAttachments);
            this.groupBox1.Controls.Add(this.txtSender);
            this.groupBox1.Controls.Add(this.btnAttachments);
            this.groupBox1.Controls.Add(this.txtBody);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtReceiver);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 594);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnAttachments2
            // 
            this.btnAttachments2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAttachments2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachments2.Location = new System.Drawing.Point(84, 508);
            this.btnAttachments2.Name = "btnAttachments2";
            this.btnAttachments2.Size = new System.Drawing.Size(75, 23);
            this.btnAttachments2.TabIndex = 19;
            this.btnAttachments2.Text = "Select 2";
            this.btnAttachments2.UseVisualStyleBackColor = true;
            this.btnAttachments2.Visible = false;
            this.btnAttachments2.Click += new System.EventHandler(this.btnAttachments2_Click);
            // 
            // lblAttachResult2
            // 
            this.lblAttachResult2.Location = new System.Drawing.Point(10, 565);
            this.lblAttachResult2.Name = "lblAttachResult2";
            this.lblAttachResult2.Size = new System.Drawing.Size(345, 23);
            this.lblAttachResult2.TabIndex = 18;
            this.lblAttachResult2.Text = ".";
            this.lblAttachResult2.Visible = false;
            // 
            // lblAttachResult
            // 
            this.lblAttachResult.Location = new System.Drawing.Point(10, 534);
            this.lblAttachResult.Name = "lblAttachResult";
            this.lblAttachResult.Size = new System.Drawing.Size(345, 23);
            this.lblAttachResult.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbGmailWarn);
            this.groupBox2.Controls.Add(this.lblSenderName);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Location = new System.Drawing.Point(234, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 193);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Service - Login Info";
            // 
            // pbGmailWarn
            // 
            this.pbGmailWarn.Image = ((System.Drawing.Image)(resources.GetObject("pbGmailWarn.Image")));
            this.pbGmailWarn.Location = new System.Drawing.Point(149, 20);
            this.pbGmailWarn.Name = "pbGmailWarn";
            this.pbGmailWarn.Size = new System.Drawing.Size(20, 20);
            this.pbGmailWarn.TabIndex = 9;
            this.pbGmailWarn.TabStop = false;
            this.pbGmailWarn.Visible = false;
            this.pbGmailWarn.Click += new System.EventHandler(this.pbGmailWarn_Click);
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Location = new System.Drawing.Point(21, 53);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(38, 13);
            this.lblSenderName.TabIndex = 8;
            this.lblSenderName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GMail",
            "Outlook(Live.com)",
            "Yandex"});
            this.comboBox1.Location = new System.Drawing.Point(21, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(20, 106);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(21, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(21, 122);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 21);
            this.txtMail.TabIndex = 2;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(6, 33);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(45, 13);
            this.lblSender.TabIndex = 8;
            this.lblSender.Text = "Sender:";
            this.lblSender.Visible = false;
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Location = new System.Drawing.Point(6, 73);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(53, 13);
            this.lblReceiver.TabIndex = 9;
            this.lblReceiver.Text = "Receiver:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(6, 113);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(47, 13);
            this.lblSubject.TabIndex = 11;
            this.lblSubject.Text = "Subject:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(6, 243);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(35, 13);
            this.lblBody.TabIndex = 12;
            this.lblBody.Text = "Body:";
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.Location = new System.Drawing.Point(6, 487);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(67, 13);
            this.lblAttachments.TabIndex = 13;
            this.lblAttachments.Text = "Attachment:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(471, 18);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(48, 48);
            this.btnHome.TabIndex = 8;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 609);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Mail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSendMail_FormClosed);
            this.Load += new System.EventHandler(this.frmSendMail_Load);
            this.Resize += new System.EventHandler(this.frmSendMail_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGmailWarn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAttachments;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAttachResult2;
        private System.Windows.Forms.Label lblAttachResult;
        private System.Windows.Forms.Button btnAttachments2;
        private System.Windows.Forms.PictureBox pbGmailWarn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnHome;
    }
}