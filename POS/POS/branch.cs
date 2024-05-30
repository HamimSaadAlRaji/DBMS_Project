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
        public string districtName;
        public string Location;

        public branch(string branchName, string districtName, string location)
        {
            this.branchName = branchName;
            this.districtName = districtName;
            Location = location;
        }

    }
}
