using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_Interface
{
    class Order
    {
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public OrderDetail OrderDetail { get; set; }

       

        public Order(DateTime date, string status, OrderDetail orderDetail)
        {
            Date = date;
            Status = status;
            OrderDetail = orderDetail;
        }
    }
}
