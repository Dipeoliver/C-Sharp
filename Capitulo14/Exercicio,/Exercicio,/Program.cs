using Exercicio_.models.Entities;
using System;
using Exercicio_.models.Enums;

namespace Exercicio_
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 10, color = Color.White };
            IShape s2 = new Rectangle() { Width = 2, height = 3, color = Color.Black };

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());

        }
    }
}
