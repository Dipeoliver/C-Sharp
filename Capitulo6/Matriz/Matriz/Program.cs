using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancia na memoria uma matriz de 2 linhas e 3 colunas
            double[,] mat = new double[2, 3];

            // verificar a quantidade de itens tem a matriz
            Console.WriteLine( mat.Length);

            // verificar a quantidade de linhas da matriz
            Console.WriteLine(mat.Rank);

            // verificar o tamanho da primeira dimenção da matriz (linhas)
            Console.WriteLine(mat.GetLength(0));

            // verificar o tamanho da primeira dimenção da matriz (colunas)
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
