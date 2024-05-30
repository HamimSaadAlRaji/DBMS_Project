using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public sealed class Database
    {
        /*public void createBranchManagerAccount(BranchManaagerAccount account) { 
        
        
        }

        public void createNewSupplier(supplier supplier) { }

        public void addNewProduct(product product) { }

        public void initiateOrder() { }

        public Customer findCustomer(string phoneNumber)
        {
            return null;
        }
        public string AddnewBranchAndGetBranchID(branch b)
        {
            return "null";
        }*/

        private Database() { }

        private static Database instance;

        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }

            return instance;
        }

        private static OracleConnection GetDBConnection(string host, int port, String sid, String user, string password)
        {
            string connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=" + host + ")(PORT=" + port + "))(CONNECT_DATA=(SERVICE_NAME=" + sid + ")));User Id=" + user + ";Password=" + password;
            OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection();
            conn.ConnectionString = connString;
            return conn;
        }

        OracleConnection con = GetDBConnection("localhost", 1521, "XEPDB1", "labib", "labib");

        public bool newCustomer(Customer customer)
        {
            string insertQuery = "INSERT INTO Customer (Customer_ID, Name,Contact_Number, Email) VALUES (:CID, :name, :ConNum, :Email)";
            try
            {

                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;


                command.Parameters.Add("::CID", OracleDbType.Varchar2).Value = customer.CustomerID;
                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = customer.Name;
                command.Parameters.Add(":ConNum", OracleDbType.Varchar2).Value = customer.PhoneNum;
                command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = customer.Email;


                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Successfully Registered as a Receptionist!");

                    return true;

                }

                MessageBox.Show("Failed to register as a receptionist!");

                return false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Registration): " + ex.Message);
                con.Close();

                return false;
            }
        }

    }



}

