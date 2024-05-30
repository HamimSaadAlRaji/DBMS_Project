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
    public partial class LandingPge : Form
    {
        public LandingPge()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyManagerLogIn_1_ companyManagerLogIn_1_ = new CompanyManagerLogIn_1_();
            this.Hide();
            companyManagerLogIn_1_.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BManagerLogin b = new BManagerLogin();
            this.Hide();
            b.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
