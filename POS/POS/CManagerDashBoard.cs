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
    public partial class CManagerDashBoard : Form
    {
        public CManagerDashBoard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CmanageSuppliers cmanageSuppliers = new CmanageSuppliers();
            this.Hide();
            cmanageSuppliers.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CmanageBranch cmanageBranch = new CmanageBranch();
            this.Hide();
            cmanageBranch.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CompanyManagerLogIn_1_ companyManagerLogIn_1_ = new CompanyManagerLogIn_1_();
            this.Hide();
            companyManagerLogIn_1_.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CmanagerSetting cmanagerSetting = new CmanagerSetting();
            this.Hide();
            cmanagerSetting.Show();
        }
    }
}
