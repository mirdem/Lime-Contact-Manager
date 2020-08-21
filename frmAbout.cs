using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lime_Contact_Manager
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
           lblVersion.Text = "Version " + this.ProductVersion;
        }

        private void pbTelegram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/xfdevapps");
        }

        private void pbTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/xfDev1");

        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://xfdev.ucoz.net/index/lime-contact-manager/0-9");

        }

        private void btnSF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/lime-contact-manager/");

        }
    }
}
