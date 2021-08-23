using System;
using System.Globalization;
namespace ExercicioClasse3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario worker = new Funcionario();
            Console.Write("Nome: ");
            worker.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            worker.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            worker.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Funcionário: {worker}");
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o sálário: ");
            double porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {worker.Nome}, $ {worker.AumentarSalario(porcento)}");

    
        }
    }
}
