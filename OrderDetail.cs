using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Interface
{
    class OrderDetail
    {
        public int Quantity { get; set; }
        public string TaxStatus { get; set; }
        public Item Item { get; set; }

        public OrderDetail(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }

       
        public void CalcWeight()
        { }
    }
}
