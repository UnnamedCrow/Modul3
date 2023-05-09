using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Part_2
{
    /// <summary>
    ///  { Name = "Андрей", Phone = 79994500508 },
    /// </summary>
    public class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }

        public Contact() { }
        public Contact(string name, long phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
