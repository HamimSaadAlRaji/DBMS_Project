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
    public partial class CManageExistingSupplier : Form
    {
        public CManageExistingSupplier()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CmanageSuppliers cmanageSuppliers = new CmanageSuppliers();
            this.Hide();
            cmanageSuppliers.Show();
        }
    }
}
