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
    public partial class CManageExistingSupplier : Form
    {
        Database db = Database.GetInstance();
        List<Supplier> suppliers;
        Supplier selectedSupplier;

        public CManageExistingSupplier()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CmanageSuppliers cmanageSuppliers = new CmanageSuppliers();
            this.Hide();
            cmanageSuppliers.Show();
        }

        private void CManageExistingSupplier_Load(object sender, EventArgs e)
        {
            SupplierList.Items.Add("ID\t\tName\t\tContactNum\t\tAddress");
            suppliers = db.getSupplierList();
            foreach (Supplier supplier in suppliers)
            {
                SupplierList.Items.Add($"{supplier.SupplierId}\t\t{supplier.SupplierName}\t\t{supplier.ContactNum}\t\t{supplier.Address}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SupplierList.SelectedItem != null)
            {
                var s = SupplierList.SelectedItem;
                string temp = s.ToString();
                string[] parts = temp.Split('\t'); 
                string id = parts[0]; 
                foreach(Supplier supplier in suppliers)
                {
                    if(id == supplier.SupplierId)
                    {
                        selectedSupplier = supplier;
                        break;
                    }
                }
                CProductOfSupplier addProductPage = new CProductOfSupplier(selectedSupplier);
                this.Hide();
                addProductPage.Show();
            }
            else
            {
                MessageBox.Show("Please select a supplier.", "No Supplier Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
