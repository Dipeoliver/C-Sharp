using System;

namespace ExercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de linhas da matriz e colunas da matriz: ");
            string[] vect = (Console.ReadLine().Split(' '));

            int line = int.Parse(vect[0]);
            int row = int.Parse(vect[1]);

            int[,] mat = new int[line, row];

            for (int i = 0; i < line; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < row; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite o numero que quer pesquisar: ");
            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (mat[i, j] == search)
                    {
                        Console.WriteLine("Position: " + i + "," + j);
                    }
                    //if (j > 0)
                    //{
                    //    Console.WriteLine("Left: " + mat[i, j - 1]);
                    //}
                    //if (i > 0)
                    //{
                    //    Console.WriteLine("Up: " + mat[i - 1, j]);
                    //}
                    //if (j < line - 1)
                    //{
                    //    Console.WriteLine("Right: " + mat[i, j + 1]);
                    //}
                    //if (i < row - 1)
                    //{
                    //    Console.WriteLine("Down: " + mat[i + 1, j]);
                    //}
                }
            }
        }
    }
}
