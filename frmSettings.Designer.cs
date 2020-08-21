namespace Lime_Contact_Manager
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.txtWinStarts = new System.Windows.Forms.TextBox();
            this.txtSysTray = new System.Windows.Forms.TextBox();
            this.chxMinimizeTray = new System.Windows.Forms.CheckBox();
            this.chxStartsWin = new System.Windows.Forms.CheckBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.cbxLang = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSendMail = new System.Windows.Forms.TextBox();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.txtContacts = new System.Windows.Forms.TextBox();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.txtViews = new System.Windows.Forms.TextBox();
            this.txtNewRecord = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.lblRunStartup = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtWinStarts);
            this.tabPage1.Controls.Add(this.txtSysTray);
            this.tabPage1.Controls.Add(this.chxMinimizeTray);
            this.tabPage1.Controls.Add(this.chxStartsWin);
            this.tabPage1.Controls.Add(this.lblLang);
            this.tabPage1.Controls.Add(this.cbxLang);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GENERAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDeleteDB);
            this.groupBox1.Location = new System.Drawing.Point(7, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 163);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delete my Database. Attention! This process deletes all your data and you will ne" +
    "ver be able to return your data at the end of this process.";
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteDB.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDB.Image")));
            this.btnDeleteDB.Location = new System.Drawing.Point(217, 94);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(73, 63);
            this.btnDeleteDB.TabIndex = 9;
            this.btnDeleteDB.Text = "Delete";
            this.btnDeleteDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // txtWinStarts
            // 
            this.txtWinStarts.Location = new System.Drawing.Point(321, 100);
            this.txtWinStarts.Name = "txtWinStarts";
            this.txtWinStarts.Size = new System.Drawing.Size(100, 21);
            this.txtWinStarts.TabIndex = 8;
            this.txtWinStarts.Visible = false;
            // 
            // txtSysTray
            // 
            this.txtSysTray.Location = new System.Drawing.Point(321, 128);
            this.txtSysTray.Name = "txtSysTray";
            this.txtSysTray.Size = new System.Drawing.Size(100, 21);
            this.txtSysTray.TabIndex = 7;
            this.txtSysTray.Visible = false;
            // 
            // chxMinimizeTray
            // 
            this.chxMinimizeTray.AutoSize = true;
            this.chxMinimizeTray.Location = new System.Drawing.Point(16, 54);
            this.chxMinimizeTray.Name = "chxMinimizeTray";
            this.chxMinimizeTray.Size = new System.Drawing.Size(144, 17);
            this.chxMinimizeTray.TabIndex = 5;
            this.chxMinimizeTray.Text = "Minimize to System Tray ";
            this.chxMinimizeTray.UseVisualStyleBackColor = true;
            this.chxMinimizeTray.CheckedChanged += new System.EventHandler(this.chxMinimizeTray_CheckedChanged);
            // 
            // chxStartsWin
            // 
            this.chxStartsWin.AutoSize = true;
            this.chxStartsWin.Location = new System.Drawing.Point(16, 31);
            this.chxStartsWin.Name = "chxStartsWin";
            this.chxStartsWin.Size = new System.Drawing.Size(282, 17);
            this.chxStartsWin.TabIndex = 4;
            this.chxStartsWin.Text = "Run Lime Contact Manager when the computer starts";
            this.chxStartsWin.UseVisualStyleBackColor = true;
            this.chxStartsWin.CheckedChanged += new System.EventHandler(this.chxStartsWin_CheckedChanged);
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(321, 34);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(86, 13);
            this.lblLang.TabIndex = 3;
            this.lblLang.Text = "Select Language";
            this.lblLang.Visible = false;
            // 
            // cbxLang
            // 
            this.cbxLang.FormattingEnabled = true;
            this.cbxLang.Items.AddRange(new object[] {
            "English",
            "Turkce"});
            this.cbxLang.Location = new System.Drawing.Point(321, 54);
            this.cbxLang.Name = "cbxLang";
            this.cbxLang.Size = new System.Drawing.Size(133, 21);
            this.cbxLang.TabIndex = 2;
            this.cbxLang.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.txtSendMail);
            this.tabPage2.Controls.Add(this.txtEvents);
            this.tabPage2.Controls.Add(this.txtContacts);
            this.tabPage2.Controls.Add(this.txtBackup);
            this.tabPage2.Controls.Add(this.txtPrint);
            this.tabPage2.Controls.Add(this.txtViews);
            this.tabPage2.Controls.Add(this.txtNewRecord);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox4);
            this.tabPage2.Controls.Add(this.checkBox5);
            this.tabPage2.Controls.Add(this.checkBox6);
            this.tabPage2.Controls.Add(this.checkBox7);
            this.tabPage2.Controls.Add(this.lblRunStartup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OTHER";
            // 
            // txtSendMail
            // 
            this.txtSendMail.Location = new System.Drawing.Point(209, 246);
            this.txtSendMail.Name = "txtSendMail";
            this.txtSendMail.Size = new System.Drawing.Size(100, 21);
            this.txtSendMail.TabIndex = 15;
            this.txtSendMail.Visible = false;
            // 
            // txtEvents
            // 
            this.txtEvents.Location = new System.Drawing.Point(209, 213);
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.Size = new System.Drawing.Size(100, 21);
            this.txtEvents.TabIndex = 14;
            this.txtEvents.Visible = false;
            // 
            // txtContacts
            // 
            this.txtContacts.Location = new System.Drawing.Point(209, 180);
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.Size = new System.Drawing.Size(100, 21);
            this.txtContacts.TabIndex = 13;
            this.txtContacts.Visible = false;
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(209, 148);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(100, 21);
            this.txtBackup.TabIndex = 12;
            this.txtBackup.Visible = false;
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(209, 116);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(100, 21);
            this.txtPrint.TabIndex = 11;
            this.txtPrint.Visible = false;
            // 
            // txtViews
            // 
            this.txtViews.Location = new System.Drawing.Point(209, 89);
            this.txtViews.Name = "txtViews";
            this.txtViews.Size = new System.Drawing.Size(100, 21);
            this.txtViews.TabIndex = 10;
            this.txtViews.Visible = false;
            // 
            // txtNewRecord
            // 
            this.txtNewRecord.Location = new System.Drawing.Point(209, 60);
            this.txtNewRecord.Name = "txtNewRecord";
            this.txtNewRecord.Size = new System.Drawing.Size(100, 21);
            this.txtNewRecord.TabIndex = 9;
            this.txtNewRecord.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Add New Record";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "View Records";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(24, 120);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Print - Export";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(24, 152);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(108, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Backup - Restore";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(24, 184);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Contacts";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(24, 217);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(59, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Events";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(24, 250);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(71, 17);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Send Mail";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // lblRunStartup
            // 
            this.lblRunStartup.AutoSize = true;
            this.lblRunStartup.Location = new System.Drawing.Point(21, 33);
            this.lblRunStartup.Name = "lblRunStartup";
            this.lblRunStartup.Size = new System.Drawing.Size(137, 13);
            this.lblRunStartup.TabIndex = 0;
            this.lblRunStartup.Text = "Features to run at startup:\r\n";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(378, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 452);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.Resize += new System.EventHandler(this.frmSettings_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cbxLang;
        private System.Windows.Forms.CheckBox chxStartsWin;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblRunStartup;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox txtNewRecord;
        private System.Windows.Forms.TextBox txtSendMail;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.TextBox txtContacts;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.TextBox txtViews;
        private System.Windows.Forms.TextBox txtSysTray;
        private System.Windows.Forms.TextBox txtWinStarts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteDB;
        public System.Windows.Forms.CheckBox chxMinimizeTray;
    }
}