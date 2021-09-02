using Exercicio_Composition2.Entities;
using Exercicio_Composition2.Entities.Enums;
using System;
using System.Globalization;

namespace Exercicio_Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth date (dd/MM/yyyy):"); ;
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Client client = new Client(name, email, birthdate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data");
                Console.Write("Product name:");
                string nameitem = Console.ReadLine();
                Console.Write("Product price:");
                double priceitem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(nameitem, priceitem);

                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, priceitem, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order SUMMARY:");
            Console.WriteLine(order);






        }
    }
}
