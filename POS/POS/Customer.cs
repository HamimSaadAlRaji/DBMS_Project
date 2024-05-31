using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace POS
{
    public class Customer
    {
        public string PhoneNum { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string phoneNum, string name, string email)
        {
            PhoneNum = phoneNum;
            Name = name;
            Email = email;
        }
    }

}
