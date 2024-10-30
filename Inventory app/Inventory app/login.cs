using DocumentFormat.OpenXml.Drawing.Diagrams;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_app
{
    public partial class login : Form
    {
        private string email = "admin@admin.com";
        private string password = "admin1";

        public login()
        {
            InitializeComponent();
        }

        
        private bool UsernameExistsInExcel(string username, string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                // Iterate through the rows to check for the username
                for (int row = 2; row <= rowCount; row++) // Assuming the first row contains headers
                {
                    string cellValue = worksheet.Cells[row, 5].Text; 
                    if (cellValue.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Username found
                    }
                }
            }
            return false; // Username not found
        }
        
        private bool pwExistsInExcel(string pw, string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                // Iterate through the rows to check for the username
                for (int row = 2; row <= rowCount; row++) // Assuming the first row contains headers
                {
                    string cellValue = worksheet.Cells[row, 6].Text;
                    if (cellValue.Equals(pw, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Username found
                    }
                }
            }
            return false; // Username not found
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string pass = txtpw.Text;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EndUsers.xlsx");

            if (email == txtusername.Text.ToString() && password == txtpw.Text.ToString())
            {
                Adminpage admin = new Adminpage();
                admin.Show();
                this.Hide();
            }
            else if(UsernameExistsInExcel(username, path)&& pwExistsInExcel(pass,path))
            {
                Enduserpage user = new Enduserpage();
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not a registered user\n Please contact your admin", "");
                txtusername.Clear();
                txtpw.Clear();
            }
            
        }
        
        private void login_Load(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }
        
    }
}
