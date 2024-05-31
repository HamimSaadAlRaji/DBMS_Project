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
    public partial class CsupplierAddition : Form
    {
        Database db = Database.GetInstance();
        public CsupplierAddition()
        {
            InitializeComponent();
        }

        private void contactNumTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string contactNum = contactTB.Text;
            string address = addressTB.Text;
            Supplier newSupplier = new Supplier(name, contactNum, address);
            db.AddSupplier(newSupplier);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CmanageSuppliers cmanageSuppliers = new CmanageSuppliers();
            this.Hide();
            cmanageSuppliers.Show();
        }
    }
}
