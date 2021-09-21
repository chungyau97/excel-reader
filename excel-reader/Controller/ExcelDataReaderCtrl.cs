using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excel_reader.Controller
{
    public class ExcelDataReaderCtrl
    {
        public IEnumerable<DataTable> ExcelFileReader(string filePath)
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                //open file and returns as Stream
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        DataSet dsWorksheet = reader.AsDataSet();
                        IEnumerable<DataTable> tables = dsWorksheet.Tables.Cast<DataTable>();
                        return tables;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
