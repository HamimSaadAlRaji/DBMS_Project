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
    public partial class addNewProduct : Form
    {
        Database db = Database.GetInstance();
        Supplier supplier;
        public addNewProduct(Supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addNewProduct_Load(object sender, EventArgs e)
        {
            suppName.Text = supplier.SupplierName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.ProductName = productNameTextBox.Text;
            newProduct.Price = Convert.ToDecimal(priceTB.Text);
            newProduct.ProductDescription = DescTB.Text;
            newProduct.ProductID = db.addProduct(newProduct);
            db.addProductofSupplier(supplier, newProduct);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            CProductOfSupplier cpsup = new CProductOfSupplier(supplier);
            this.Hide();
            cpsup.Show();
        }
    }
}
