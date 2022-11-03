using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MockDataSource:IDataSource
    {

        public List<Email> emails { get; set; }
        public List<Contact> contacts { get; set; }

        void init()
        {
            emails = new List<Email>();
            emails.Add(new Email()
            {
                id=1,
                subject = "important",
                sender = new Contact() { name = "sara", email = "123@co.il" },
                receiver = new Contact() { name = "lea", email = "456@co.il" }
            });

            emails.Add(new Email()
            {
                id = 2,
                subject = "abc",
                sender = new Contact() { name = "sara", email = "sara@co.il" },
                receiver = new Contact() { name = "rachel", email = "rachel@co.il" }
            }) ;

        }
       

        public List<Email> GetAll()
        {
            if (emails == null) init();
            return emails;
        }

        public void insertEmail(Email email)
        {
            emails.Add(email);

        }
        public void updateEmail(int emailId)
        {
        }

        public void deleteEmail(int emailId)
        {
            Email currEmail = null;
            foreach (var item in emails)
            {
                if (item.id == emailId)
                    currEmail = item;
            }
            emails.Remove(currEmail);
        }
    }
}
