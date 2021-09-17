using ExercicioIterface.Entities;
using ExercicioIterface.Services;
using System;
using System.Globalization;

namespace ExercicioIterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Vehicle vehicle = new Vehicle(carModel);


            Console.Write("Pickup (dd/MM/YYYY hh:mm): ");
            DateTime pickupDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/YYYY hh:mm): ");
            DateTime returnDate = DateTime.Parse(Console.ReadLine());
            Rent rent = new Rent(pickupDate, returnDate, vehicle);

            Console.Write("Enter  the  price per hour: ");
            double priceperHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter  the  price per day: ");
            double priceperDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            RentalService rentalService = new RentalService(priceperHour, priceperDay, new BrazilTaxService());
            rentalService.ProcessInvoice(rent);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rent.Invoice);
        }
    }
}
