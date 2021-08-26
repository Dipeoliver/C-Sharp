using Enumerações.Entities;
using Enumerações.Entities.Enums;
using System;

namespace Enumerações
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);

            // conversão de enum para string.
            string txt = OrderStatus.Pendingpayment.ToString();                                     
            Console.WriteLine(txt);

            // conversão string to enum;
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
