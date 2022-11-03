
using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
           emailBL emailSerMock =Utilities.ConfigEmailDependencies("Mock");
           emailBL emailSerSQL =Utilities.ConfigEmailDependencies("SQL");

            var list = emailSerMock.GetAll();
            var list2 = emailSerSQL.GetAll();


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
