using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFinalCapitulo10.Entities;

namespace ExercicioFinalCapitulo10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c) ? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpendure = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new PF(name, anualIncome, healthExpendure));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployeess = int.Parse(Console.ReadLine());
                    list.Add(new PJ(name, anualIncome, numberOfEmployeess));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (People people in list)
            {
                Console.WriteLine($"{people.Name}: $ {people.Taxes().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            double totaltax = 0;
            foreach (People people in list)
            {
                totaltax += people.Taxes();
            }
            Console.Write($"TOTAL TAXES: $ ");
            Console.WriteLine(totaltax.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
