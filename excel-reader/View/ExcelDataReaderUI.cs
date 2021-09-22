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
        private void ButtonAvailability(bool value)
        {
            btnA.Enabled = value;
            btnB.Enabled = value;
        }
        private void Reset()
        {
            try
            {
                txtFilePath.Text = string.Empty;
                cmbNumSheet.Items.Clear();
                dgvExcelData.DataSource = null;
                ButtonAvailability(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ExcelDataReaderUI_Load(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
                string filePath = setPathName();
                PopulateComboBox(filePath);
                ButtonAvailability(true);
            }
            catch(Exception ex)
            {
                Console.Clear();
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


        private void btnA_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelDataReaderCtrl edrc = new ExcelDataReaderCtrl();
                lblA.Text = edrc.ChangeColumnName(listDt[cmbNumSheet.SelectedIndex], 'A');
                PopulateDataGridView(cmbNumSheet.SelectedIndex);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelDataReaderCtrl edrc = new ExcelDataReaderCtrl();
                lblB.Text = edrc.ChangeColumnName(listDt[cmbNumSheet.SelectedIndex], 'B');
                PopulateDataGridView(cmbNumSheet.SelectedIndex);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
