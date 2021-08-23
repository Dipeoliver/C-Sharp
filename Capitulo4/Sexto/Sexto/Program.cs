using System;
using System.Globalization;
namespace Sexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1= new Produto();

            Console.WriteLine("Entre com os dados dos Produtos:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p1.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto" + p1);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qte);
            Console.WriteLine("Total de estoque"+ p1);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qterem = int.Parse(Console.ReadLine());
            p1.RemoveProdutos(qterem);
            Console.WriteLine("Total de estoque" + p1);


        }
    }
}
