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
        public BDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BInventory inventoryPage = new BInventory();
            this.Hide();
            inventoryPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            this.Hide();
            newOrder.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BManagerLogin login = new BManagerLogin();
            this.Hide();
            login.Show();
        }
    }
}
