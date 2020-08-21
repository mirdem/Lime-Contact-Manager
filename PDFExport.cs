using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
class PDFExport
{
        public string FileName { get; set; } //pdf oluşturacağımız dosya adı
        public string Text { get; set; } //dosyanın içinde oluşturacağımız pdf adı
        public int PdfRowIndex { get; set; } //pdfrowindex
        public string Path { get; set; }

        public DataTable ToDatatable()
        {
            //DataTable Oluştur            
            DataTable dt = new DataTable("");
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));
            dt.Columns.Add(new DataColumn("", typeof(string)));

            return dt;

        }
        public void ToPdf(DataGridView dgGecKalanKitap)
        {

            DataTable dtPDF = ToDatatable();
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            string dosya = "C\test.pdf"; //PDF imiz nereye kayıt edilecek ?
            PdfWriter.GetInstance(document, new FileStream(dosya, FileMode.Create));
            BaseFont arial = BaseFont.CreateFont("C:\\windows\\fonts\\tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(arial, 12, Font.NORMAL);
            document.Open();
            PdfPTable table = null;
            table = new PdfPTable(dgGecKalanKitap.Columns.Count);
            table.WidthPercentage = 100;
            string str = string.Empty;
            for (int i = 0; i < dgGecKalanKitap.Columns.Count; i++)
            {
                str += dgGecKalanKitap.Columns[i].HeaderText;
                if (dgGecKalanKitap.Columns.Count > i)
                    str += "+";
            }

            string str2 = str.TrimEnd('+').ToString();

            ///<summary></summary>
            /// DataGridView kolonlarının sayısı kadar belgenin başlıkları doldurulur.
            /// Pdf hücreleri oluşturulur.Dökumandaki başlık kısmı için ilk satır oluşturulur ve colspan yapılır.
            ///

            PdfPCell cell = new PdfPCell(new Phrase(dosya));
            cell.Colspan = dgGecKalanKitap.Columns.Count;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);

            ///<summary></summary>
            ///pdf tablosu hücreleri doldurulur
            ///

            for (int i = 0; i < dgGecKalanKitap.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dgGecKalanKitap.Columns[i].HeaderText, font));
            }

            for (int i = 0; i < dtPDF.Rows.Count; i++)
            {
                for (int j = 0; j < dtPDF.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dtPDF.Rows[i][j].ToString(), font));

                    PdfRowIndex++;
                }
            }
            document.Add(table);

            MessageBox.Show("Kaydınız Başarıyla Tamamlanmıştır!" + "n" + "Kayıt Yeri" + "" +dosya, "Aktarım Sonucu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            document.Close();
        }

        /// <summary></summary>


    }
