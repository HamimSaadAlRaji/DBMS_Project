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
    public partial class CompanyManagerLogIn_1_ : Form
    {
        public CompanyManagerLogIn_1_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LandingPge form1 = new LandingPge();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = Password.Text;

            if (pass == "admin") //check if branchID, pass is available
            {
                CManagerDashBoard mDashboard = new CManagerDashBoard();
                this.Hide();
                mDashboard.Show();
            }
            else
            {
                passMitchMatch.Text = "Password didn't match";
            } 
        }
    }
}
