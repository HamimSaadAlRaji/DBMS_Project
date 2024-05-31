using Oracle.ManagedDataAccess.Client;
using System;
using System.Net;
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

        OracleConnection con = GetDBConnection("localhost", 1521, "XEPDB1", "pos", "pos");

        public bool newCustomer(Customer customer)
        {
            string insertQuery = "INSERT INTO Customer (Name,Contact_Number, Email) VALUES (:name, :ConNum, :Email)";
            try
            {

                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;


                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = customer.Name;
                command.Parameters.Add(":ConNum", OracleDbType.Varchar2).Value = customer.PhoneNum;
                command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = customer.Email;


                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Customer Added!");

                    return true;

                }

                MessageBox.Show("Customer Exist!");

                return false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred(Registration): " + ex.Message);
                con.Close();

                return false;
            }
        }
        public string AddnewBranchAndGetBranchID(branch b)
        {
            string insertQuery = "INSERT INTO Branch (Branch_Name, Address) VALUES (:BranchName, :Address)";
            try
            {
                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;

                command.Parameters.Add(":BranchName", OracleDbType.Varchar2).Value = b.branchName;
                command.Parameters.Add(":Address", OracleDbType.Varchar2).Value = b.Location;


                int rowsInserted = command.ExecuteNonQuery();
                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("branch Added!");

                }

                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return findBranchID(b.branchName,b.Location);
        }
        public string findBranchID(string branchName, string Adress)
        {
            string result = null;
            string query = "SELECT Branch_ID FROM Branch WHERE Branch_Name = :BranchName AND Address = :Address";
            try
            {
                con.Open();

                OracleCommand command = new OracleCommand(query, con);

                // Adding parameters to avoid SQL injection
                command.Parameters.Add(":BranchName", OracleDbType.Varchar2).Value = branchName;
                command.Parameters.Add(":Address", OracleDbType.Varchar2).Value = Adress;

                // Execute the query and fetch the result
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Return the Branch_ID
                        result =  reader["Branch_ID"].ToString();
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return result;
        }
        public bool addNewCredential(string id, string pass)
        {
            string insertQuery = "INSERT INTO Credentials (Branch_ID, password) VALUES (:branchId, :password)";
            try
            {
                con.Open();

                OracleCommand command = new OracleCommand();

                command.CommandText = insertQuery;
                command.Connection = con;

                // Assuming you have a 'credentials' object with properties 'BranchId' and 'Password'
                command.Parameters.Add(":branchId", OracleDbType.Varchar2).Value = id;
                command.Parameters.Add(":password", OracleDbType.Varchar2).Value = pass;

                int rowsInserted = command.ExecuteNonQuery();

                con.Close();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Credentials Added!");
                    return true;
                }

                MessageBox.Show("Credentials Exist!");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred (Credentials): " + ex.Message);
                //con.Close();
                return false;
            }

        }

        //LogIn
        public bool VerifyCredentials(string branchId, string password)
        {
            bool isValid = false;
            string query = "SELECT COUNT(*) FROM Credentials WHERE Branch_ID = :BranchID AND password = :Password";
            try
            {
                con.Open();

                OracleCommand command = new OracleCommand(query, con);

                // Adding parameters to avoid SQL injection
                command.Parameters.Add(":BranchID", OracleDbType.Varchar2).Value = branchId;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = password;

                // Execute the query and fetch the result
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    isValid = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                con.Close();
            }
            return isValid;
        }

        //searching customer 

        public Customer findCustomerByPhone(string phoneNum)
        {
            Customer customer = null;
            string query = "SELECT Name, Email FROM Customer WHERE Contact_Number = :PhoneNum";

            try
            {
                con.Open();

                OracleCommand command = new OracleCommand(query, con);

                // Adding parameters to avoid SQL injection
                command.Parameters.Add(":PhoneNum", OracleDbType.Varchar2).Value = phoneNum;

                // Execute the query and fetch the result
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Create a new Customer instance with the retrieved data
                        customer = new Customer(
                            phoneNum,
                            reader["Name"].ToString(),
                            reader["Email"].ToString()
                        );
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return customer;
        }


    }
}

