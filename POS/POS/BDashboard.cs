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
    public partial class BDashboard : Form
    {
        string branchID;
        public BDashboard(string branchID)
        {
            InitializeComponent();
            this.branchID = branchID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BInventory inventoryPage = new BInventory(branchID);
            this.Hide();
            inventoryPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder(branchID);
            this.Hide();
            newOrder.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BManagerLogin login = new BManagerLogin(branchID);
            this.Hide();
            login.Show();
        }

        private void BDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
