using ExercicioPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando uma lista de funcionários
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsoursed (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'n')
                {
                    list.Add(new Employee(name, hours, value));
                }
                else
                {
                    Console.Write("Aditional Charge ");
                    double aditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, value, aditionalCharge));
                }
                Console.WriteLine();
            }
            Console.WriteLine("PAYMENTS");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj.Name + " - $" + obj.Payment().ToString("F2"), CultureInfo.InvariantCulture);
            }

        }
    }
}
