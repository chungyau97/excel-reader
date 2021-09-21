using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel_reader.Controller;

namespace excel_reader
{
    public partial class ExcelDataReaderUI : Form
    {
        public ExcelDataReaderUI()
        {
            InitializeComponent();
        }
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = setPathName();
                setDataGridView(filePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        private string setPathName()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                string filePath = ofd.FileName.ToString();
                txtFilePath.Text = filePath;
                return filePath;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void setDataGridView(string filePath)
        {
            try
            {
                ExcelDataReaderCtrl edrc = new ExcelDataReaderCtrl();
                IEnumerable<DataTable> tables = edrc.ExcelFileReader(filePath);
                foreach(DataTable table in tables)
                {
                    dgvExcelData.DataSource = table;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
