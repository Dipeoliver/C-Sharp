using System;
using System.Globalization;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            while (true)
            {
                Console.WriteLine("Digite um numero");
                valor = Math.Sqrt(double.Parse(Console.ReadLine()));
                if (valor>= 0)
                {
                    Console.WriteLine("O valor da raiz é:" + valor.ToString("F3",CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Valor negativo");
                    break;
                }
            }

        }
    }
}
