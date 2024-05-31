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
        bool exist = false;
        string branchID;
        public BNewOrder2(string branchID)
        {
            InitializeComponent();
            this.branchID = branchID;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contactNum = contactNumTB.Text;
            string mail = mailTB.Text;
            string name = nameTB.Text;
              
            if(!exist)
            {
                if (mail != "" && name != "")
                {
                    Customer Cus = new Customer(contactNum, mail, name);
                    db.newCustomer(Cus);
                }
                else
                {
                    MessageBox.Show("Add Name and Email.");
                }
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contact = contactNumTB.Text;

            nameTB.Clear();
            mailTB.Clear();
            
            // search in database

            Customer cus = db.findCustomerByPhone(contact);


            if (cus != null)
            {
                contactNumTB.Text = cus.PhoneNum;
                mailTB.Text = cus.Email;
                nameTB.Text = cus.Name;

                exist = true;
            }
            else
            {
                label9.Text = "New Customer, Add Manually.";
                exist = false;
            }



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BNewOrder2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewOrder nu = new NewOrder(branchID);
            this.Hide();
            nu.Show();
        }
    }
}
