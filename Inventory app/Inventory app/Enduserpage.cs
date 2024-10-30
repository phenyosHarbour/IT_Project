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
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Inventory_app
{
    public partial class Enduserpage : Form
    {
        private DataTable itemtable;
        public Enduserpage()
        {
            InitializeComponent();
            InitializeDataTable();
            
        }
        private void InitializeDataTable()
        {
            itemtable = new DataTable();
            itemtable.Columns.Add("ID", typeof(int));
            itemtable.Columns.Add("Item-Name", typeof(string));
            itemtable.Columns.Add("Quantity", typeof(int));
            itemtable.Columns.Add("Price", typeof(double));
;
        }
        private void Enduserpage_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randownumber = random.Next(1, 1001);
            txtcode.Text = randownumber.ToString();
        }
        private void btnitem_Click(object sender, EventArgs e)
        {
            DataRow row = itemtable.NewRow();
            row["ID"] = int.Parse(txtcode.Text);
            row["Item-Name"] = txtname.Text;
            row["Quantity"] = int.Parse(numericquintity.Text);
            row["Price"] = double.Parse(txtprice.Text);
            itemtable.Rows.Add(row);

            DialogResult ok = MessageBox.Show("Item successfully added","",MessageBoxButtons.OK);

            if (ok == DialogResult.OK)
            {
                Random random = new Random();
                int randownumber = random.Next(1, 1001);
                txtcode.Text = randownumber.ToString();
                txtname.Clear();
                txtprice.Clear();
                dgvlist.DataSource = itemtable;
                dgvlist.Refresh();
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InventoryItems.xlsx");

            // Check if the file exists
            using (var workbook = File.Exists(path) ? new XLWorkbook(path) : new XLWorkbook())
            {
                IXLWorksheet worksheet;

                // If the file already has the worksheet, get it; otherwise, create a new worksheet
                if (workbook.Worksheets.Contains("Inventory Items"))
                {
                    worksheet = workbook.Worksheet("Inventory Items");
                }
                else
                {
                    worksheet = workbook.Worksheets.Add("Inventory Items");
                    // Add headers if this is a new worksheet
                    for (int i = 0; i < itemtable.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = itemtable.Columns[i].ColumnName;
                    }
                }

                // Find the first empty row to append the new data
                int lastRow = worksheet.LastRowUsed().RowNumber();
                int startRow = lastRow + 1;

                // Append the new data rows from itemtable
                foreach (DataRow row in itemtable.Rows)
                {
                    for (int i = 0; i < itemtable.Columns.Count; i++)
                    {
                        worksheet.Cell(startRow, i + 1).Value = row[i]?.ToString();
                    }
                    startRow++;
                }

                // Save the workbook
                workbook.SaveAs(path);
            }

            DialogResult result = MessageBox.Show("Items successfully submitted to the system", "Submit", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                itemtable.Clear();
                dgvlist.Refresh();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure", "", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }


    }
}
