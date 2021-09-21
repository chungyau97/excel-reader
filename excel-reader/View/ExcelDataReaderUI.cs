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
        List<DataTable> listDt;
        public ExcelDataReaderUI()
        {
            InitializeComponent();
        }
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
                string filePath = setPathName();
                PopulateComboBox(filePath);
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
        private void PopulateComboBox(string filePath)
        {
            try
            {
                ExcelDataReaderCtrl edrc = new ExcelDataReaderCtrl(); 
                IEnumerable<DataTable> tables = edrc.ExcelFileReader(filePath);
                listDt = tables.ToList();
                int numWorkSheets = tables.Count();
                for(int i = 1; i <= numWorkSheets; i++)
                {
                    cmbNumSheet.Items.Add(i);
                }
                cmbNumSheet.SelectedIndex = 0;
                PopulateDataGridView();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void PopulateDataGridView(int i = 0)
        {
            try
            {
                dgvExcelData.DataSource = listDt[i];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbNumSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PopulateDataGridView(cmbNumSheet.SelectedIndex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Reset()
        {
            try
            {
                txtFilePath.Text = string.Empty;
                cmbNumSheet.Items.Clear();
                dgvExcelData.DataSource = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
