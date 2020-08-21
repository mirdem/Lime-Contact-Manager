namespace Lime_Contact_Manager
{
    partial class frmSetupDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetupDB));
            this.grbWelcome = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNextWelcome = new System.Windows.Forms.Button();
            this.lblWarn = new System.Windows.Forms.Label();
            this.grbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblInfoMail = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.btnBackInfos = new System.Windows.Forms.Button();
            this.btnNextInfos = new System.Windows.Forms.Button();
            this.lblMaxChar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.lblMailSum = new System.Windows.Forms.Label();
            this.lblPassSum = new System.Windows.Forms.Label();
            this.lblSumUserName = new System.Windows.Forms.Label();
            this.lblWarn2 = new System.Windows.Forms.Label();
            this.btnBackSummary = new System.Windows.Forms.Button();
            this.btnSaveFinish = new System.Windows.Forms.Button();
            this.grbWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbLoginInfo.SuspendLayout();
            this.grbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbWelcome
            // 
            this.grbWelcome.Controls.Add(this.pictureBox1);
            this.grbWelcome.Controls.Add(this.btnNextWelcome);
            this.grbWelcome.Controls.Add(this.lblWarn);
            this.grbWelcome.Location = new System.Drawing.Point(12, 12);
            this.grbWelcome.Name = "grbWelcome";
            this.grbWelcome.Size = new System.Drawing.Size(392, 367);
            this.grbWelcome.TabIndex = 1;
            this.grbWelcome.TabStop = false;
            this.grbWelcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnNextWelcome
            // 
            this.btnNextWelcome.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNextWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextWelcome.Location = new System.Drawing.Point(292, 326);
            this.btnNextWelcome.Name = "btnNextWelcome";
            this.btnNextWelcome.Size = new System.Drawing.Size(75, 23);
            this.btnNextWelcome.TabIndex = 6;
            this.btnNextWelcome.Text = "Next";
            this.btnNextWelcome.UseVisualStyleBackColor = true;
            this.btnNextWelcome.Click += new System.EventHandler(this.btnNextWelcome_Click);
            // 
            // lblWarn
            // 
            this.lblWarn.Location = new System.Drawing.Point(7, 20);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(355, 48);
            this.lblWarn.TabIndex = 0;
            this.lblWarn.Text = "Welcome to the setup wizard. This will be done once for each user. Please take no" +
    "te of the information you entered.";
            // 
            // grbLoginInfo
            // 
            this.grbLoginInfo.Controls.Add(this.lblInfoMail);
            this.grbLoginInfo.Controls.Add(this.txtEMail);
            this.grbLoginInfo.Controls.Add(this.lblEMail);
            this.grbLoginInfo.Controls.Add(this.btnBackInfos);
            this.grbLoginInfo.Controls.Add(this.btnNextInfos);
            this.grbLoginInfo.Controls.Add(this.lblMaxChar);
            this.grbLoginInfo.Controls.Add(this.label2);
            this.grbLoginInfo.Controls.Add(this.label1);
            this.grbLoginInfo.Controls.Add(this.txtPassword);
            this.grbLoginInfo.Controls.Add(this.txtUserName);
            this.grbLoginInfo.Location = new System.Drawing.Point(440, 12);
            this.grbLoginInfo.Name = "grbLoginInfo";
            this.grbLoginInfo.Size = new System.Drawing.Size(392, 367);
            this.grbLoginInfo.TabIndex = 0;
            this.grbLoginInfo.TabStop = false;
            this.grbLoginInfo.Text = "Login Informations";
            this.grbLoginInfo.Visible = false;
            // 
            // lblInfoMail
            // 
            this.lblInfoMail.Location = new System.Drawing.Point(200, 123);
            this.lblInfoMail.Name = "lblInfoMail";
            this.lblInfoMail.Size = new System.Drawing.Size(186, 44);
            this.lblInfoMail.TabIndex = 15;
            this.lblInfoMail.Text = "*Required to reach you in case you forget your password.";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(93, 120);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(100, 21);
            this.txtEMail.TabIndex = 8;
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(17, 120);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(39, 13);
            this.lblEMail.TabIndex = 13;
            this.lblEMail.Text = "E-Mail:";
            // 
            // btnBackInfos
            // 
            this.btnBackInfos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBackInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackInfos.Location = new System.Drawing.Point(217, 325);
            this.btnBackInfos.Name = "btnBackInfos";
            this.btnBackInfos.Size = new System.Drawing.Size(75, 23);
            this.btnBackInfos.TabIndex = 9;
            this.btnBackInfos.Text = "Back";
            this.btnBackInfos.UseVisualStyleBackColor = true;
            this.btnBackInfos.Click += new System.EventHandler(this.btnBackInfos_Click);
            // 
            // btnNextInfos
            // 
            this.btnNextInfos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNextInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextInfos.Location = new System.Drawing.Point(298, 325);
            this.btnNextInfos.Name = "btnNextInfos";
            this.btnNextInfos.Size = new System.Drawing.Size(75, 23);
            this.btnNextInfos.TabIndex = 10;
            this.btnNextInfos.Text = "Next";
            this.btnNextInfos.UseVisualStyleBackColor = true;
            this.btnNextInfos.Click += new System.EventHandler(this.btnNextInfos_Click);
            // 
            // lblMaxChar
            // 
            this.lblMaxChar.AutoSize = true;
            this.lblMaxChar.Location = new System.Drawing.Point(200, 65);
            this.lblMaxChar.Name = "lblMaxChar";
            this.lblMaxChar.Size = new System.Drawing.Size(101, 13);
            this.lblMaxChar.TabIndex = 10;
            this.lblMaxChar.Text = "*Max. 20 character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(93, 58);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 6;
            // 
            // grbSummary
            // 
            this.grbSummary.Controls.Add(this.lblMailSum);
            this.grbSummary.Controls.Add(this.lblPassSum);
            this.grbSummary.Controls.Add(this.lblSumUserName);
            this.grbSummary.Controls.Add(this.lblWarn2);
            this.grbSummary.Controls.Add(this.btnBackSummary);
            this.grbSummary.Controls.Add(this.btnSaveFinish);
            this.grbSummary.Location = new System.Drawing.Point(446, 12);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(392, 367);
            this.grbSummary.TabIndex = 0;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "Summary";
            this.grbSummary.Visible = false;
            // 
            // lblMailSum
            // 
            this.lblMailSum.AutoSize = true;
            this.lblMailSum.Location = new System.Drawing.Point(56, 141);
            this.lblMailSum.Name = "lblMailSum";
            this.lblMailSum.Size = new System.Drawing.Size(39, 13);
            this.lblMailSum.TabIndex = 5;
            this.lblMailSum.Text = "E-Mail:";
            // 
            // lblPassSum
            // 
            this.lblPassSum.AutoSize = true;
            this.lblPassSum.Location = new System.Drawing.Point(53, 118);
            this.lblPassSum.Name = "lblPassSum";
            this.lblPassSum.Size = new System.Drawing.Size(57, 13);
            this.lblPassSum.TabIndex = 4;
            this.lblPassSum.Text = "Password:";
            // 
            // lblSumUserName
            // 
            this.lblSumUserName.AutoSize = true;
            this.lblSumUserName.Location = new System.Drawing.Point(53, 95);
            this.lblSumUserName.Name = "lblSumUserName";
            this.lblSumUserName.Size = new System.Drawing.Size(59, 13);
            this.lblSumUserName.TabIndex = 3;
            this.lblSumUserName.Text = "Username:";
            // 
            // lblWarn2
            // 
            this.lblWarn2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWarn2.Location = new System.Drawing.Point(14, 21);
            this.lblWarn2.Name = "lblWarn2";
            this.lblWarn2.Size = new System.Drawing.Size(363, 74);
            this.lblWarn2.TabIndex = 2;
            this.lblWarn2.Text = "Please check the information you entered. Your information is correct, the \"Save " +
    "and Finish\" button is not correct \"Back\" button.";
            // 
            // btnBackSummary
            // 
            this.btnBackSummary.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBackSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSummary.Location = new System.Drawing.Point(187, 329);
            this.btnBackSummary.Name = "btnBackSummary";
            this.btnBackSummary.Size = new System.Drawing.Size(75, 23);
            this.btnBackSummary.TabIndex = 1;
            this.btnBackSummary.Text = "Back";
            this.btnBackSummary.UseVisualStyleBackColor = true;
            this.btnBackSummary.Click += new System.EventHandler(this.btnBackSummary_Click);
            // 
            // btnSaveFinish
            // 
            this.btnSaveFinish.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFinish.Location = new System.Drawing.Point(268, 329);
            this.btnSaveFinish.Name = "btnSaveFinish";
            this.btnSaveFinish.Size = new System.Drawing.Size(118, 23);
            this.btnSaveFinish.TabIndex = 0;
            this.btnSaveFinish.Text = "Save and Finish";
            this.btnSaveFinish.UseVisualStyleBackColor = true;
            this.btnSaveFinish.Click += new System.EventHandler(this.btnSaveFinish_Click);
            // 
            // frmSetupDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 388);
            this.Controls.Add(this.grbLoginInfo);
            this.Controls.Add(this.grbSummary);
            this.Controls.Add(this.grbWelcome);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSetupDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User Setup Wizard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSetupDB_FormClosed);
            this.Load += new System.EventHandler(this.frmSetupDB_Load);
            this.grbWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbLoginInfo.ResumeLayout(false);
            this.grbLoginInfo.PerformLayout();
            this.grbSummary.ResumeLayout(false);
            this.grbSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbWelcome;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.GroupBox grbLoginInfo;
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.Button btnNextWelcome;
        private System.Windows.Forms.Button btnBackInfos;
        private System.Windows.Forms.Button btnNextInfos;
        private System.Windows.Forms.Label lblMaxChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBackSummary;
        private System.Windows.Forms.Button btnSaveFinish;
        private System.Windows.Forms.Label lblWarn2;
        private System.Windows.Forms.Label lblPassSum;
        private System.Windows.Forms.Label lblSumUserName;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblInfoMail;
        private System.Windows.Forms.Label lblMailSum;
    }
}