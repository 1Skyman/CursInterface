using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Interface
{
    class Lasagne:IFood
    {
        public string Type { get; set; }

        public double CalculatePrice()
        {
            return 0;
        }

        public void SetType(string type)
        {
           
        }
    }
}
