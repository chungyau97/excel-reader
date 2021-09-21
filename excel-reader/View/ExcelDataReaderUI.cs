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
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                string filePath = ofd.FileName.ToString();
                ExcelDataReaderCtrl edrc = new ExcelDataReaderCtrl();
                label1.Text =  edrc.GetFilePath(filePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
