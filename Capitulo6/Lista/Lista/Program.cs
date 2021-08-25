using System;
using System.Collections.Generic;
namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // adicionar intens na lista(ao final da lista);
            list.Add("Maria");
            list.Add("joao");
            list.Add("alex");
            list.Add("ana");

            // adicionar itens na lista porem em determinada posição
            list.Insert(2, "Marcos");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------");

            // contar a quantidade de intens na tela.
            Console.WriteLine("list count = " + list.Count);

            // encontar na lista o primeiro elemento que começe com uma letra determinada
            // dentro do parentese tenho de passar uma função
            string s1 = list.Find(x => x[0] == 'j');
            Console.WriteLine("The first name is: " + s1);
            // ultima ocorrencia do nome que começa com a letra A
            string s2 = list.FindLast(x => x[0] == 'a');
            Console.WriteLine("Last a: " + s2);
            //Achar primeira POSIÇÂO que comece com uma letra especifica.
            int s3 = list.FindIndex(x => x[0] == 'a');
            Console.WriteLine("First position  a: " + s3);
            //Achar ultimo POSIÇÂO que comece com uma letra especifica.
            int s4 = list.FindLastIndex(x => x[0] == 'a');
            Console.WriteLine("Last position a: " + s4);
            // filtrar lista(criar nova lista apenas com itens especificos)
            List<string> list2 = list.FindAll(x => x.Length >= 5);
            Console.WriteLine("-------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----remove range-------");
            // remover um range de itens a partir da posição 0 remover 1 item
            list.RemoveRange(0,1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("----remove position 2-------");
            // remover item pela posição
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----remove item-------");
            // remover itens especifico da lista
            list.Remove("ana");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----remove all start M-----");
            // remover todos os itens da lista que comecem com a letra m
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
