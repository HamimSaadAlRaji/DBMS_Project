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
        Database db = Database.GetInstance();
        public NewOrder()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            BNewOrder2 bNewOrder2 = new BNewOrder2();
            this.Hide();
            bNewOrder2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BDashboard b = new BDashboard();
            this.Hide();
            b.Show();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int q = int.Parse(textBox2.Text);

            Product product = db.getProductFromProductID(s);


            listBox1.Items.Add(product.ProductName + " \t " + textBox2.Text+"\t"+ product.Price*q);
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Product Name" + " \t " + "Quantity" + " \t " + "Amount");
        }
    }
}
