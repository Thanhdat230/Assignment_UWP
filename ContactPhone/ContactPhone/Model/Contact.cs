using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPhone.Model
{
    class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string CreationDate { get; set; }

        public Contact()
        {

        }

        public Contact(string name, string phone)
        {
            Name = name;
            PhoneNumber = phone;
            CreationDate = DateTime.Now.ToString();
        }
    }
}
