using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
                        DataSet dsWorksheet = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
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

        public string ChangeColumnName(DataTable dt, char Choice)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string index = string.Empty;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (Choice == 'A')
                    {
                        index = IndexToColumnA(i + 1);
                    }
                    else if (Choice == 'B')
                    {
                        index = IndexToColumnB(i + 1);
                    }
                    else
                    {
                        throw new Exception("Logic is not handle.");
                    }
                    dt.Columns[i].ColumnName = index;
                }
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                return string.Format("{0:00}:{1:00}:{2:00}.{3}",
                                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string IndexToColumnA(int index)
        {
            try
            {
                const int ColumnBase = 26;
                const int DigitMax = 7; // ceil(log26(Int32.Max))
                const string Digits = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                if (index <= 0)
                    throw new IndexOutOfRangeException("index must be a positive number");

                if (index <= ColumnBase)
                    return Digits[index - 1].ToString();

                var sb = new StringBuilder().Append(' ', DigitMax);
                var current = index;
                var offset = DigitMax;
                while (current > 0)
                {
                    sb[--offset] = Digits[--current % ColumnBase];
                    current /= ColumnBase;
                }
                return sb.ToString(offset, DigitMax - offset);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string IndexToColumnB(int value)
        {
            try
            {
                string result = string.Empty;
                while (--value >= 0)
                {
                    result = (char)('A' + value % 26) + result;
                    value /= 26;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
