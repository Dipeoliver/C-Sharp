using System;
using System.Globalization;
namespace ExercicioClasse4
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno student = new Aluno();
            Console.Write("Nome do Aluno: ");
            student.Nome = Console.ReadLine();
            Console.WriteLine("Digite três notas do aluno: ");
            student.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NOTA FINAL = {student.NotaFinal()}");
            if (student.Avaliação() == "APROVADO")
            {
                Console.WriteLine(student.Avaliação(),CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine(student.Avaliação(),CultureInfo.InvariantCulture);
                Console.WriteLine($"FALTARAM {student.NotaFalta()} PONTOS");
            }

        }
    }
}
