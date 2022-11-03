using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Email
    {
        public int id { get; set; }
        public string subject { get; set; }
        public Contact sender { get; set; }
        public Contact receiver { get; set; }

        public override string ToString()
        {
            return $"{nameof(id)}:{id} , " +
                $"{nameof(subject)}:{subject}, " +
                $"{nameof(sender)}:{sender}," +
                $"{nameof(receiver)}:{receiver}";
        }






    }
}
