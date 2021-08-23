using System;
using System.Globalization;
namespace Sexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv",500,10);

            Console.WriteLine(p.GetNome());
            p.SetNome("TV a cabo");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());




        }
    }
}
