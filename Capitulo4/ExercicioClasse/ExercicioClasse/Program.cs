using System;

namespace ExercicioClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Pessoa1, Pessoa2;

            Pessoa1 = new Pessoa();
            Pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome e idade da 1° Pessoa");
            Pessoa1.Nome = Console.ReadLine();
            Pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da 2° Pessoa");
            Pessoa2.Nome = Console.ReadLine();
            Pessoa2.Idade = int.Parse(Console.ReadLine());

            if (Pessoa1.Idade > Pessoa2.Idade) Console.WriteLine($"A pessoa mais velha é: {Pessoa1.Nome} com {Pessoa1.Idade} anos");
            else Console.WriteLine($"A pessoa mais velha é: {Pessoa2.Nome} com {Pessoa2.Idade} anos");
        }
    }
}
