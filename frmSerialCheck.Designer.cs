namespace Lime_Contact_Manager
{
    partial class frmSerialCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerialCheck));
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLicence = new System.Windows.Forms.Label();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSavedMailShow = new System.Windows.Forms.Label();
            this.lblSavedKeyShow = new System.Windows.Forms.Label();
            this.lblSavedKey = new System.Windows.Forms.Label();
            this.lblHideSerial = new System.Windows.Forms.Label();
            this.lblHideMail = new System.Windows.Forms.Label();
            this.lblNowDate = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDiskCheck = new System.Windows.Forms.Timer(this.components);
            this.timerTarihOku = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(185, 136);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEMail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblLicence);
            this.groupBox1.Controls.Add(this.txtLicence);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Serial Number:";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(6, 107);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(254, 21);
            this.txtEMail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter E-Mail (Write the mail you used to purchase.)";
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLicence.Location = new System.Drawing.Point(7, 31);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(201, 13);
            this.lblLicence.TabIndex = 6;
            this.lblLicence.Text = "Enter your 16-character license number.";
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(6, 50);
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Size = new System.Drawing.Size(254, 21);
            this.txtLicence.TabIndex = 5;
            this.txtLicence.TextChanged += new System.EventHandler(this.txtLicence_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblSavedMailShow);
            this.groupBox2.Controls.Add(this.lblSavedKeyShow);
            this.groupBox2.Controls.Add(this.lblSavedKey);
            this.groupBox2.Location = new System.Drawing.Point(13, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registered Info";
            // 
            // lblSize
            // 
            this.lblSize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSize.Location = new System.Drawing.Point(205, 87);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(49, 23);
            this.lblSize.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Registired Mail:";
            // 
            // lblSavedMailShow
            // 
            this.lblSavedMailShow.AutoSize = true;
            this.lblSavedMailShow.Location = new System.Drawing.Point(97, 56);
            this.lblSavedMailShow.Name = "lblSavedMailShow";
            this.lblSavedMailShow.Size = new System.Drawing.Size(0, 13);
            this.lblSavedMailShow.TabIndex = 2;
            // 
            // lblSavedKeyShow
            // 
            this.lblSavedKeyShow.AutoSize = true;
            this.lblSavedKeyShow.Location = new System.Drawing.Point(97, 33);
            this.lblSavedKeyShow.Name = "lblSavedKeyShow";
            this.lblSavedKeyShow.Size = new System.Drawing.Size(0, 13);
            this.lblSavedKeyShow.TabIndex = 1;
            // 
            // lblSavedKey
            // 
            this.lblSavedKey.AutoSize = true;
            this.lblSavedKey.Location = new System.Drawing.Point(10, 33);
            this.lblSavedKey.Name = "lblSavedKey";
            this.lblSavedKey.Size = new System.Drawing.Size(67, 13);
            this.lblSavedKey.TabIndex = 0;
            this.lblSavedKey.Text = "Licence Key:\r\n";
            // 
            // lblHideSerial
            // 
            this.lblHideSerial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHideSerial.Location = new System.Drawing.Point(362, 44);
            this.lblHideSerial.Name = "lblHideSerial";
            this.lblHideSerial.Size = new System.Drawing.Size(242, 23);
            this.lblHideSerial.TabIndex = 9;
            // 
            // lblHideMail
            // 
            this.lblHideMail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHideMail.Location = new System.Drawing.Point(362, 73);
            this.lblHideMail.Name = "lblHideMail";
            this.lblHideMail.Size = new System.Drawing.Size(242, 23);
            this.lblHideMail.TabIndex = 10;
            // 
            // lblNowDate
            // 
            this.lblNowDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNowDate.Location = new System.Drawing.Point(362, 123);
            this.lblNowDate.Name = "lblNowDate";
            this.lblNowDate.Size = new System.Drawing.Size(242, 23);
            this.lblNowDate.TabIndex = 11;
            // 
            // lblExpDate
            // 
            this.lblExpDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExpDate.Location = new System.Drawing.Point(362, 154);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(242, 23);
            this.lblExpDate.TabIndex = 12;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(414, 198);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 21);
            this.txtDurum.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 350;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDiskCheck
            // 
            this.timerDiskCheck.Tick += new System.EventHandler(this.timerDiskCheck_Tick);
            // 
            // timerTarihOku
            // 
            this.timerTarihOku.Interval = 500;
            this.timerTarihOku.Tick += new System.EventHandler(this.timerTarihOku_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(450, 342);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 1, 12, 50, 20, 0);
            // 
            // frmSerialCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 316);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblNowDate);
            this.Controls.Add(this.lblHideSerial);
            this.Controls.Add(this.lblHideMail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSerialCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lime Contact Manager Buy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSerialCheck_FormClosed);
            this.Load += new System.EventHandler(this.frmSerialCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSavedKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblSavedMailShow;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblSavedKeyShow;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblHideSerial;
        private System.Windows.Forms.Label lblHideMail;
        private System.Windows.Forms.Label lblNowDate;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerDiskCheck;
        private System.Windows.Forms.Timer timerTarihOku;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}