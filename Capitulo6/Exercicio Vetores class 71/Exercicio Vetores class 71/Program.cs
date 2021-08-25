using System;


namespace Exercicio_Vetores_class_71
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleQuartos[] vect = new ControleQuartos[10];

            Console.Write("How many rooms will be rented ?");
            int qte = int.Parse(Console.ReadLine());

            for (int i = 0; i < qte; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new ControleQuartos(name, email); // passa parametros para o construtor
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
        }
    }
}
