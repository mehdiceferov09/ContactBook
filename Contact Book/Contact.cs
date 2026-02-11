using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Book
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Mail {  get; set; }
        public int Number { get; set; }

        public Contact(string name, string mail = "", decimal number = 0)
        {
            Name = name;
            Mail = mail;
            Number = Convert.ToInt32(number);
        }
    }
}
