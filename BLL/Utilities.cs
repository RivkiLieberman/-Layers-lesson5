using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Utilities
    {
        public static emailBL ConfigEmailDependencies(string s)
        {
            switch (s)
            {
                case "Mock": return new emailBL(new MockDataSource());
                case "SQL":
                default: return new emailBL(new SQLDataSource());
            }
        }
    }
}
