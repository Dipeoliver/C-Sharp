using System;
using Exercicio_StringBuilder.Entities;
using System.Globalization;
using System.Collections.Generic;


namespace Exercicio_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 2;
            for (int i = 0; i < n; i++)
            {
                DateTime moment = DateTime.Now;
                Console.Write("Digite o Titulo: ");
                string title = Console.ReadLine();

                Console.Write("Digite o conteudo: ");
                string content = Console.ReadLine();

                Console.Write("Quantidade de likes ");
                int like = int.Parse(Console.ReadLine());

                Post post = new Post(moment, title, content, like);

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Comentarios: ");
                    Comment comment = new Comment(Console.ReadLine());
                    post.AddComment(comment);
                }
                Console.WriteLine();
                Console.WriteLine(post);
            }


        }
    }
}
