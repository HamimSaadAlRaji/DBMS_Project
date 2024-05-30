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
    public partial class CmanageSuppliers : Form
    {
        public CmanageSuppliers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CManagerDashBoard cManagerDashBoard = new CManagerDashBoard();
            this.Hide();
            cManagerDashBoard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CManageExistingSupplier supplier = new CManageExistingSupplier();
            this.Hide();
            supplier.Show();
        }
    }
}
