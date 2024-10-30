using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_app
{
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            Add_end_user user = new Add_end_user();
            user.Show();
            this.Hide();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ManageInv inv = new ManageInv();
            inv.Show();
            this.Hide();
        }

        private void btnmanage_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
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
    }
}
