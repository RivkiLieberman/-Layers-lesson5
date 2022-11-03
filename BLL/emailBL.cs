using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class emailBL
    {

        IDataSource ds;
        private SQLDataSource sQLDataSource;

        public emailBL(IDataSource ds)
        {
            this.ds = ds;
        }

     

        public List<Email> GetAll()
        {
            
            List<Email> list = ds.GetAll();
            return list;
        }
    }
}
