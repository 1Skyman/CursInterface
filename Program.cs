using System;

namespace Tema_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Jim", "1 mai");
            customer1.Orders = new Order[3];
            Item newItem = new Item();
            newItem.Description = "O piine";
            
            OrderDetail newOrder = new OrderDetail(newItem, 3);

             customer1.Orders[0] = new Order(DateTime.Now, "pending",newOrder);
            Console.WriteLine(customer1.Orders[0].OrderDetail.Item.Description);


        }
    }
}
