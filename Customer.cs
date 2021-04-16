using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Interface
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Order[] Orders { get; set; }

        public Customer(string name, string address)

        {
            Name = name;
            Address = address;
        }
    }
}
