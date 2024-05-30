using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class branch
    {
        public string branchName; 
        public string Location;

        public branch(string branchName,   string location)
        {
            this.branchName = branchName; 
            Location = location;
        }

    }
}
