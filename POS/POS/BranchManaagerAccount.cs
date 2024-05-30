using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class BranchManaagerAccount
    {
        public string ID;
        public string password; 
        public BranchManaagerAccount(string ID, string password) {
            this.ID = ID;
            this.password = password;
        }
    } 
}
