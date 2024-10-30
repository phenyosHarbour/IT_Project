using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using OfficeOpenXml;
using System.IO.Packaging;

namespace Inventory_app
{
    public partial class Add_end_user : Form
    {
        private DataTable userstable;
        public Add_end_user()
        {
            InitializeComponent();
            InitializeDataTable();
        }
        private void InitializeDataTable()
        {
            userstable = new DataTable();
            userstable.Columns.Add("EmpCode", typeof(string));
            userstable.Columns.Add("Name", typeof(string));
            userstable.Columns.Add("Surname", typeof(string));
            userstable.Columns.Add("DOB", typeof(string));
            userstable.Columns.Add("Email", typeof(string));
            userstable.Columns.Add("Password", typeof(string));
            userstable.Columns.Add("CellPhone", typeof(int));
            
        }
        private void Add_end_user_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int Rndnumber = random.Next(1, 10001);
            txtcode.Text = "INV"+Rndnumber.ToString();
            txtpw.Text = GenerateRandomPassword(8);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbemp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Filter for image files
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox
                    pbemp.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
        private void btnsubmity_Click(object sender, EventArgs e)
        {
            DataRow row = userstable.NewRow();
            row["EmpCode"] = txtcode.Text;
            row["Name"] = txtname.Text;
            row["Surname"] = txtsurname.Text;
            row["DOB"] = dtpdob.Text;
            row["Email"] = txtemail.Text;
            row["Password"] = txtpw.Text;
            row["Cellphone"] = int.Parse(txtcell.Text);
            userstable.Rows.Add(row);

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EndUsers.xlsx");
            using (var workbook = new XLWorkbook())
            using (ExcelPackage package = new ExcelPackage(path))
            {
                //var Worksheet = workbook.Worksheets.Add("UsersDetails");
                //Worksheet.Cell(1, 1).InsertTable(userstable);
                //workbook.SaveAs(path);
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Get the first worksheet

                // Find the last used row
                int lastRow = worksheet.Dimension.End.Row;

                // Append the DataTable starting from the next row
                worksheet.Cells[lastRow + 1, 1].LoadFromDataTable(userstable, false);

                // Save the changes
                package.Save();
            }

            DialogResult result = MessageBox.Show("End-User has been successfully added", "Submit", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Random random = new Random();
                int Rndnumber = random.Next(1, 10001);
                txtcode.Text = "INV" + Rndnumber.ToString();
                txtpw.Text = GenerateRandomPassword(8);

                txtname.Text = "";
                txtsurname.Text = "";
                dtpdob.Text = "";
                txtemail.Text = "";
                txtcell.Text = "";
            }
        }
        static string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-+=<>?";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(validChars.Length);
                password.Append(validChars[index]);
            }

            return password.ToString();
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
