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
    public partial class BInventory : Form
    {
        public BInventory()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BDashboard mDashboard = new BDashboard();
            this.Hide();
            mDashboard.Show();
        }
    }
}
