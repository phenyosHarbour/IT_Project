using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Inventory_app
{
    public partial class ManageInv : Form
    {
        private DataTable invTable;
        public ManageInv()
        {
            InitializeComponent();
        }

        private void ManageInv_Load(object sender, EventArgs e)
        {

        }

        private void SaveExcel(string filePath)
        {
            // Delete the existing file if it exists
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                // Add a new worksheet or handle worksheet name conflicts
                var worksheet = package.Workbook.Worksheets.Add("Inventory Items");

                // Add column headers
                for (int i = 0; i < invTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = invTable.Columns[i].ColumnName;
                }

                // Add data rows
                for (int i = 0; i < invTable.Rows.Count; i++)
                {
                    for (int j = 0; j < invTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = invTable.Rows[i][j];
                    }
                }

                // Save the package to persist changes to the file
                package.Save();
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
           
        }

        private void ManageInv_Load_1(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InventoryItems.xlsx");
            FileInfo fileInfo = new FileInfo(path);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                invTable = new DataTable();

                // Load the headers
                foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    invTable.Columns.Add(firstRowCell.Text);
                }

                // Load the data
                for (var rowNum = 2; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    var row = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                    var newRow = invTable.NewRow();
                    foreach (var cell in row)
                    {
                        newRow[cell.Start.Column - 1] = cell.Text;
                    }
                    invTable.Rows.Add(newRow);
                }
            }

            dgvinvview1.DataSource = invTable;
        }

        private void btnsave1_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InventoryItems.xlsx");
            SaveExcel(path);
            DialogResult res = MessageBox.Show("Changes saved", "");
        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInvview.SelectedRows)
            {
                dgvInvview.Rows.RemoveAt(row.Index);
            }
            DialogResult res = MessageBox.Show("Record successfully deleted", "");
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Adminpage ad = new Adminpage();
            ad.Show();
            this.Hide();
        }
    }
}
