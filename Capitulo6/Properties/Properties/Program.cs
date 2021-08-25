using System;
using System.Globalization;
namespace Sexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500, 10);

            Console.WriteLine(p.Nome);
            p.Nome = "TV a cabo";
            Console.WriteLine(p.Nome);

            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        }
    }
}
