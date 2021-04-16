using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Interface
{
    class Check: Payment
    {
        public string Name { get; set; }
        public string BankID { get; set; }

        public void Authotized()
        { }
    }
}
