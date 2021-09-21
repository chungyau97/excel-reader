using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excel_reader.Controller
{
    public class ExcelDataReaderCtrl
    {
        string filePath = string.Empty;
        string errorMsg = "Unable to open file.";
        public string GetFilePath(string filePath)
        {
            try
            {
                this.filePath = filePath;
                return this.filePath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
