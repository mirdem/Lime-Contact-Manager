namespace Lime_Contact_Manager
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSupport = new System.Windows.Forms.Button();
            this.pbTelegram = new System.Windows.Forms.PictureBox();
            this.pbTwitter = new System.Windows.Forms.PictureBox();
            this.btnSF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelegram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lime Contact Manager";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(97, 164);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(65, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version Info";
            // 
            // btnSupport
            // 
            this.btnSupport.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.Location = new System.Drawing.Point(172, 224);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(92, 23);
            this.btnSupport.TabIndex = 3;
            this.btnSupport.Text = "Go To Support";
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // pbTelegram
            // 
            this.pbTelegram.Image = ((System.Drawing.Image)(resources.GetObject("pbTelegram.Image")));
            this.pbTelegram.Location = new System.Drawing.Point(12, 222);
            this.pbTelegram.Name = "pbTelegram";
            this.pbTelegram.Size = new System.Drawing.Size(50, 50);
            this.pbTelegram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTelegram.TabIndex = 4;
            this.pbTelegram.TabStop = false;
            this.pbTelegram.Click += new System.EventHandler(this.pbTelegram_Click);
            // 
            // pbTwitter
            // 
            this.pbTwitter.Image = ((System.Drawing.Image)(resources.GetObject("pbTwitter.Image")));
            this.pbTwitter.Location = new System.Drawing.Point(68, 224);
            this.pbTwitter.Name = "pbTwitter";
            this.pbTwitter.Size = new System.Drawing.Size(48, 48);
            this.pbTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTwitter.TabIndex = 5;
            this.pbTwitter.TabStop = false;
            this.pbTwitter.Click += new System.EventHandler(this.pbTwitter_Click);
            // 
            // btnSF
            // 
            this.btnSF.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSF.Location = new System.Drawing.Point(172, 254);
            this.btnSF.Name = "btnSF";
            this.btnSF.Size = new System.Drawing.Size(92, 23);
            this.btnSF.TabIndex = 6;
            this.btnSF.Text = "SF Page";
            this.btnSF.UseVisualStyleBackColor = true;
            this.btnSF.Click += new System.EventHandler(this.btnSF_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 284);
            this.Controls.Add(this.btnSF);
            this.Controls.Add(this.pbTwitter);
            this.Controls.Add(this.pbTelegram);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelegram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.PictureBox pbTelegram;
        private System.Windows.Forms.PictureBox pbTwitter;
        private System.Windows.Forms.Button btnSF;
    }
}