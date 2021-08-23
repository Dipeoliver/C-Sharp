using System;
using System.Globalization;
namespace ExercicioClasseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            Cotacao.ValorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            Cotacao.Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Valor a ser pago em reais = {Cotacao.ValorPago().ToString("F2",CultureInfo.InvariantCulture)}");
            



        }
    }
}
