using System;
using System.Globalization;

namespace quarto_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Quantos números irá Digitar:");
            //int quantidade = int.Parse(Console.ReadLine());
            //int v = 0;
            //for (int i = 1; i <= quantidade; i++)
            //{
            //    v += int.Parse(Console.ReadLine());               
            //}
            //Console.WriteLine(v);

            // --------------------------------------------------

            //Console.Write("Digite um número: ");
            //int impar = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= impar; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}

            // --------------------------------------------------

            //Console.WriteLine("Digite o número de casos de teste");
            //int casos = int.Parse(Console.ReadLine());


            //for ( int i =0; i < casos; i++)
            //{
            //    string[] line = Console.ReadLine().Split(' ');
            //    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            //    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            //    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            //    double  media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            //Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            //}


            Console.WriteLine("Numero fatorial de: ");
            int casos = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i =1; i <= casos; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
