using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinalCapitulo10.Entities
{
    abstract class People
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public People() { }

        protected People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Taxes();

    }
}
