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
using Excel = Microsoft.Office.Interop.Excel;
using GridPrintPreviewLib;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
namespace Lime_Contact_Manager
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private static string password = "194553";
        SQLiteConnection con = new SQLiteConnection();


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

        void griddoldur()
             {
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            dataGridView1.Rows.Clear();

            con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\data\\databases\\" + set1.ToString() + "_database.db;Version=3;Password=" + password);

            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Veriler", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {

            read.GetValue(read.GetOrdinal("VeriID")),
            read.GetValue(read.GetOrdinal("Name")),
            read.GetValue(read.GetOrdinal("Surname")),
            read.GetValue(read.GetOrdinal("birthday")),       
            read.GetValue(read.GetOrdinal("mobilephone")),
            read.GetValue(read.GetOrdinal("workaddress")),
            read.GetValue(read.GetOrdinal("job")),
            read.GetValue(read.GetOrdinal("email1")),
            read.GetValue(read.GetOrdinal("notes"))
     });
                }
            }
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Surname";
            dataGridView1.Columns[3].HeaderText = "Birthday";
            dataGridView1.Columns[4].HeaderText = "Mobile Phone";
            dataGridView1.Columns[5].HeaderText = "Work Address";
            dataGridView1.Columns[6].HeaderText = "Job";
            dataGridView1.Columns[7].HeaderText = "E-Mail(1)";
            dataGridView1.Columns[8].HeaderText = "Notes";
           griddoldur();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GridPrintDocument doc = new GridPrintDocument(this.dataGridView1, this.dataGridView1.Font, true);
            doc.DocumentName = "Preview Test";
            doc.DefaultPageSettings.Landscape = true;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            float scale = doc.CalcScaleForFit();
            doc.ScaleFactor = scale;

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "PrintPreviewDialog1";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            doc.Dispose();
            doc = null;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        { 
            
            Excel.Application oExcel_15 = null;                
            Excel.Workbook oBook = null;                     
            Excel.Sheets oSheetsColl = null;                   
            Excel.Worksheet oSheet = null;                     
            Excel.Range oRange = null;                         
            Object oMissing = System.Reflection.Missing.Value;

            oExcel_15 = new Excel.Application();

            oExcel_15.Visible = true;

            oExcel_15.UserControl = true;


            oBook = oExcel_15.Workbooks.Add(oMissing);

            oSheetsColl = oExcel_15.Worksheets;

            oSheet = (Excel.Worksheet)oSheetsColl.get_Item(1);

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                oRange = oSheet.Cells[1, j + 1] as Excel.Range;
                oRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    oRange = oSheet.Cells[i + 2, j + 1] as Excel.Range;
                    oRange.Value2 = dataGridView1.Rows[i].Cells[j].Value;

                }
            }

            
            oBook = null;

            oExcel_15 = null;

            GC.Collect();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = Application.StartupPath+"\\data\\Export\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            StringBuilder set1 = new StringBuilder(5000);
            GetPrivateProfileString("Settings", "LoggedUser", "", set1, set1.Capacity, Application.StartupPath + "\\data\\db_settings.ini");

            using (FileStream stream = new FileStream(folderPath+ set1.ToString() + ".PDF", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                System.Diagnostics.Process.Start(folderPath);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmPrint_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmPrint_Resize(object sender, EventArgs e)
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
    }
 }

