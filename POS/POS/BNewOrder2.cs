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
    public partial class BNewOrder2 : Form
    {
        Database db = Database.GetInstance();
        public BNewOrder2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contactNum = contactNumTB.Text;
            string mail = mailTB.Text;
            string name = nameTB.Text;
            Customer Cus = new Customer(contactNum, mail, name);
            db.newCustomer(Cus);
        }
    }
}
