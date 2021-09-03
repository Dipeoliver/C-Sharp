using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinalCapitulo10.Entities
{
    class PJ : People
    {
        public int NumberOfEmplouees { get; set; }

        public PJ(string name, double annualIncome, int numberOfEmplouees) : base(name, annualIncome)
        {
            NumberOfEmplouees = numberOfEmplouees;
        }

        public override double Taxes()
        {
            double sum = 0;

            if (NumberOfEmplouees > 10)
            {
                sum = (AnnualIncome * 0.14);
                return sum;
            }
            else
            {
                sum = (AnnualIncome * 0.16);
                return sum;
            }
        }
    }
}
