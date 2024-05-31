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
    public partial class NewOrder : Form
    {
        string branchID;
        public NewOrder(string branchID)
        {
            InitializeComponent();
            this.branchID = branchID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BNewOrder2 bNewOrder2 = new BNewOrder2();
            this.Hide();
            bNewOrder2.Show();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
