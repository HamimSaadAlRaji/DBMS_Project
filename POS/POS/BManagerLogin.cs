using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class BManagerLogin : Form
    {
        Database db = Database.GetInstance();
        string branchID;
        public BManagerLogin( )
        {
            InitializeComponent(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string branchID = branchIDtextBox.Text;
            string password = PasswordTextBox.Text;

            bool match = db.VerifyCredentials(branchID, password);

            if (match) //check if branchID, pass is available
            { 
                BDashboard mDashboard = new BDashboard(branchID);
                this.Hide();
                mDashboard.Show();
            }
            else
            {
                PassMismaatch.Text = "Credentials didn't match";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LandingPge form1 = new LandingPge();
            this.Hide();
            form1.Show();
        }

        private void PassMismaatch_Click(object sender, EventArgs e)
        {

        }

        private void BManagerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
