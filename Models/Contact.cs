using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contact
    {
        public string name { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return $"{nameof(name)}:{name} , {nameof(email)}:{email}";
        }


    }
}
