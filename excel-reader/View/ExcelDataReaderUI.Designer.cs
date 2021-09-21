
namespace excel_reader
{
    partial class ExcelDataReaderUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvExcelData = new System.Windows.Forms.DataGridView();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cmbNumSheet = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExcelData
            // 
            this.dgvExcelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelData.Location = new System.Drawing.Point(0, 64);
            this.dgvExcelData.Name = "dgvExcelData";
            this.dgvExcelData.RowTemplate.Height = 25;
            this.dgvExcelData.Size = new System.Drawing.Size(800, 386);
            this.dgvExcelData.TabIndex = 0;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(12, 9);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnFilePath.TabIndex = 1;
            this.btnFilePath.Text = "Browse FIle";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(93, 9);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(695, 23);
            this.txtFilePath.TabIndex = 2;
            // 
            // cmbNumSheet
            // 
            this.cmbNumSheet.FormattingEnabled = true;
            this.cmbNumSheet.Location = new System.Drawing.Point(727, 38);
            this.cmbNumSheet.Name = "cmbNumSheet";
            this.cmbNumSheet.Size = new System.Drawing.Size(61, 23);
            this.cmbNumSheet.TabIndex = 3;
            this.cmbNumSheet.SelectedIndexChanged += new System.EventHandler(this.cmbNumSheet_SelectedIndexChanged);
            // 
            // ExcelDataReaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbNumSheet);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.dgvExcelData);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ExcelDataReaderUI";
            this.Text = "Excel Data Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExcelData;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.ComboBox cmbNumSheet;
    }
}

