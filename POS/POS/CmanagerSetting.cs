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
    public partial class CmanagerSetting : Form
    {
        public CmanagerSetting()
        {
            InitializeComponent();
        }

        private void CmanagerSetting_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CManagerDashBoard cManagerDashBoard = new CManagerDashBoard();
            this.Hide();
            cManagerDashBoard.Show();
        }
    }
}
