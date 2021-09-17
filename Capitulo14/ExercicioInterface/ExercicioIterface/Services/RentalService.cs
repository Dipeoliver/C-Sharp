using ExercicioIterface.Entities;
using System;

namespace ExercicioIterface.Services
{
    class RentalService
    {
        public double PricePerHorur { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService ;

        public RentalService(double pricePerHorur, double pricePerDay,ITaxService taxService)
        {
            PricePerHorur = pricePerHorur;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(Rent carrental)
        {
            TimeSpan duration = carrental.Finish.Subtract(carrental.Pickup);
            double basicPayment = 0;


            if (duration.TotalHours <= 12)
            {
                // Math.Ceiling -> arrendondar para cima
                basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHorur;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
            }
            double tax = _taxService.Tax (basicPayment);

            carrental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}

