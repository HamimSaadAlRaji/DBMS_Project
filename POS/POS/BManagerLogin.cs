﻿using System;
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
    public partial class BManagerLogin : Form
    {
        public BManagerLogin()
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
            BDashboard mDashboard = new BDashboard();
            this.Hide();
            mDashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LandingPge form1 = new LandingPge();
            this.Hide();
            form1.Show();
        }
    }
}
