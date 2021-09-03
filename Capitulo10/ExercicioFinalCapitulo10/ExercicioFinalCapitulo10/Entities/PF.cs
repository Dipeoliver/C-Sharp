using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinalCapitulo10.Entities
{
    class PF : People
    {
        public double HealthExpendutires { get; set; }

        public PF(string name, double annualIncome, double healthExpendutires) : base(name, annualIncome)
        {
            HealthExpendutires = healthExpendutires;
        }

        public override double Taxes()
        {
            double sum = 0;

            if (HealthExpendutires > 0)
            {

                if (AnnualIncome < 20000.00)
                {
                    sum = (AnnualIncome * 0.15) - (HealthExpendutires * 0.50);
                    return sum;
                }
                else
                {
                    sum = (AnnualIncome * 0.25) - (HealthExpendutires * 0.50);
                    return sum;
                }
            }
            else
            {
                if (AnnualIncome < 20000.00)
                {
                    sum = AnnualIncome - (AnnualIncome * 0.15);
                    return sum;
                }
                else
                {
                    sum = AnnualIncome - (AnnualIncome * 0.25);
                    return sum;
                }
            }
        }
    }
}
