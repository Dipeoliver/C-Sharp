using ExercicioTryCatch.Entities;
using ExercicioTryCatch.Entities.DomainExcepetion;
using System;
using System.Globalization;

namespace ExercicioTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balnace: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                account = new Account(number, holder, initialBalance, withDrawLimit);

                Console.Write("Enter amount for witdraw: ");
                double witDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(witDraw);
                Console.WriteLine($"New Balance: {account.Balance.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }      
        }
    }
}
