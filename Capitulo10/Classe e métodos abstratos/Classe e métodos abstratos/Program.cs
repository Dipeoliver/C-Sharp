using Classe_e_métodos_abstratos.Entities;
using Classe_e_métodos_abstratos.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Classe_e_métodos_abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or cilce (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Color (black/blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());

                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Color (black/blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape item in list)
            {
                Console.WriteLine(item.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
