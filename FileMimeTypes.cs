using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDrive.Framework
{
    internal class FileMimeTypes
    {
        internal static string FolderMimeType = "application/vnd.google-apps.folder";

        IDictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"pdf", "application/pdf"},
            {"txt", "text/plain"},
            {"doc", "application/doc"},
            {"docx", "application/docx"},
            {"xls", "application/xls"},
            {"xlsx", "application/xlsx"},
            {"ppt", "application/ppt"},
            {"pptx", "application/pptx"}
                //Tagged Image File Format (.TIFF)
                //Scalable Vector Graphics (.SVG)
                //PostScript (.EPS, .PS)
                //TrueType (.TTF)
                //XML Paper Specification (.XPS)
        };

        internal string this[string extension]
        {
            get
            {
                return dictionary.ContainsKey(extension) ? dictionary[extension] : null;
            }
        }
    }
}
