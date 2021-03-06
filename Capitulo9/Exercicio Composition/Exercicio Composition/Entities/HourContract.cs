using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Composition.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHours, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHours;
            Hours = hours;
        }

        public double TotalValue() 
        {
            return ValuePerHour * Hours;
        }
    }
}
