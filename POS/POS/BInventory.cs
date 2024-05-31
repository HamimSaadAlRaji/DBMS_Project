using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class BInventory : Form
    {
        string branchID;
        public BInventory(string branchID)
        {
            InitializeComponent();
            this.branchID = branchID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BDashboard mDashboard = new BDashboard(branchID);
            this.Hide();
            mDashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
