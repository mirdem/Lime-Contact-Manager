namespace Lime_Contact_Manager
{
    partial class frmUpdates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdates));
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblChecking = new System.Windows.Forms.Label();
            this.lblInstalled = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUpdateVer = new System.Windows.Forms.Label();
            this.pbLCM = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLCM)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoading
            // 
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(107, 58);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(64, 64);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoading.TabIndex = 0;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // lblChecking
            // 
            this.lblChecking.AutoSize = true;
            this.lblChecking.Location = new System.Drawing.Point(85, 134);
            this.lblChecking.Name = "lblChecking";
            this.lblChecking.Size = new System.Drawing.Size(122, 13);
            this.lblChecking.TabIndex = 1;
            this.lblChecking.Text = "Checking for Updates...";
            this.lblChecking.Visible = false;
            // 
            // lblInstalled
            // 
            this.lblInstalled.AutoSize = true;
            this.lblInstalled.Location = new System.Drawing.Point(81, 197);
            this.lblInstalled.Name = "lblInstalled";
            this.lblInstalled.Size = new System.Drawing.Size(90, 13);
            this.lblInstalled.TabIndex = 2;
            this.lblInstalled.Text = "Installed Version:";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUpdateVer
            // 
            this.lblUpdateVer.AutoSize = true;
            this.lblUpdateVer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateVer.Location = new System.Drawing.Point(81, 220);
            this.lblUpdateVer.Name = "lblUpdateVer";
            this.lblUpdateVer.Size = new System.Drawing.Size(112, 14);
            this.lblUpdateVer.TabIndex = 3;
            this.lblUpdateVer.Text = "Updated Version:";
            this.lblUpdateVer.Visible = false;
            // 
            // pbLCM
            // 
            this.pbLCM.Image = ((System.Drawing.Image)(resources.GetObject("pbLCM.Image")));
            this.pbLCM.Location = new System.Drawing.Point(107, 58);
            this.pbLCM.Name = "pbLCM";
            this.pbLCM.Size = new System.Drawing.Size(64, 64);
            this.pbLCM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLCM.TabIndex = 4;
            this.pbLCM.TabStop = false;
            this.pbLCM.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnRetry
            // 
            this.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Location = new System.Drawing.Point(84, 277);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(109, 23);
            this.btnRetry.TabIndex = 6;
            this.btnRetry.Text = "Check Again";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // frmUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 366);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLCM);
            this.Controls.Add(this.lblUpdateVer);
            this.Controls.Add(this.lblInstalled);
            this.Controls.Add(this.lblChecking);
            this.Controls.Add(this.pbLoading);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updates";
            this.Load += new System.EventHandler(this.frmUpdates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLCM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lblChecking;
        private System.Windows.Forms.Label lblInstalled;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUpdateVer;
        private System.Windows.Forms.PictureBox pbLCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetry;
    }
}