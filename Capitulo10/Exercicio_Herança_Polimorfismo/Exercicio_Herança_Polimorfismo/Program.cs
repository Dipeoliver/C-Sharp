﻿using Exercicio_Herança_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Herança_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufacotyDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UseProduct(name, price, manufacotyDate));
                }

            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }


    }
}
