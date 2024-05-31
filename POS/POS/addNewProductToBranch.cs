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
    public partial class addNewProductToBranch : Form
    {
        Database db = Database.GetInstance();
        string branchID;
        public addNewProductToBranch(string branchID)
        {
            InitializeComponent();
            this.branchID = branchID;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addNewProductToBranch_Load(object sender, EventArgs e)
        {
            BranchID.Text = branchID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.addProductToInventory(productID.Text, branchID);
            MessageBox.Show("DONE");
            
        }
    }
}
