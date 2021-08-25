using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Entre com a quantidade de itens da matriz: ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numver =" + count);
        }
    }
}
