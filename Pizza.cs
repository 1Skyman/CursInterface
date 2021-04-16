using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Interface
{
    class Pizza:IFood
    {
        public string Size { get; set; }
        public string Type { get; set; }

        public double CalculatePrice()
        {
            return 0;
        }

        public void SetSize(string size)
        {

        }

        public void SetType(string type)
        {
            
        }
    }
}
