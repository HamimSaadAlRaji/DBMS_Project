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
    public partial class CProductOfSupplier : Form
    {
        Database db = Database.GetInstance();
        Supplier supplier;
        public CProductOfSupplier(Supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CManageExistingSupplier existingSupplierPage = new CManageExistingSupplier();
            this.Hide();
            existingSupplierPage.Show();
        }

        private void CAddProductOfSupplier_Load(object sender, EventArgs e)
        {
            List<Product> products = db.getProductListofSupplier(supplier);
            foreach (Product product in products)
            {
                ProductsOfSuppliers.Items.Add(product.ProductName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNewProduct csupplierAddition = new addNewProduct(supplier);
            this.Hide();
            csupplierAddition.Show();
        }
    }
}
