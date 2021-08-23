
using System.Globalization;

namespace ExercicioClasse3
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquid()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double percent)
        {
            double newSalario = SalarioLiquid() + (SalarioBruto * (percent/100));
            return newSalario;
        }

        public override string ToString()
        {
            return $" {Nome}, $ {SalarioLiquid().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
