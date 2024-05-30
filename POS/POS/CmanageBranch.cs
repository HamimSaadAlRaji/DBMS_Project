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
    public partial class CmanageBranch : Form
    {
        //database db = new database();
        public CmanageBranch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string branchName = branchNameTextBox.Text;
            string branchLocaton = branchLocationTextBox.Text;
            string district = DistrictTextBox.Text;
            string password = passwordTextBox.Text;
            if (branchLocaton=="" || branchName=="" || district == "" || password == "")
            {
                nullTextIdentifier.Text = "Can not be null";
                return;
            }
            else
            {
                branch newBracnch = new branch(branchName,district,branchLocaton);
                //string branchID = db.AddnewBranchAndGetBranchID(newBracnch);

                //MessageBox.Show($"You have successfully added a branch.\nBranch ID: {branchID}\nRemember the branch ID to log into the branch account.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CManagerDashBoard cManagerDashBoard = new CManagerDashBoard();
            this.Hide();
            cManagerDashBoard.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
