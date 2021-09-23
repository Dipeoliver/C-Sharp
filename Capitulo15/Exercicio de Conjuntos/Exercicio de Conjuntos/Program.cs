using Exercicio_de_Conjuntos.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio_de_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Courses> set = new HashSet<Courses>();


            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for ( int i = 0; i < n; i++)
            {
                set.Add(new Courses { Course = "A", UserId = int.Parse(Console.ReadLine()) });
            }

            Console.Write("How many students for course B? ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                set.Add(new Courses { Course = "B", UserId = int.Parse(Console.ReadLine()) });
            }

            Console.Write("How many students for course C? ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                set.Add(new Courses { Course = "C", UserId = int.Parse(Console.ReadLine()) });
            }
            Console.WriteLine();

            Console.WriteLine("Total students: " + set.Count);


        }
    }
}
