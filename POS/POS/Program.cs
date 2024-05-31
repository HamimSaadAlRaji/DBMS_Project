using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace POS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CManageExistingSupplier());


            //Database db = Database.GetInstance();
            //List<Supplier> suppliers = db.getSupplierList();
            //foreach (Supplier supplier in suppliers)
            //{
            //    Console.WriteLine(supplier.Address+supplier.ContactNum+supplier.SupplierName);
            //}
            //Console.ReadLine();
        }
    }
}
