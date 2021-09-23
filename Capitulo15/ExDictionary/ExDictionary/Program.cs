using System;
using System.Collections.Generic;
using System.IO;

namespace ExDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> dic = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int qtyVote = int.Parse(line[1]);
                        if (dic.ContainsKey(name))
                        {
                            dic[name] += qtyVote;
                        }
                        else
                        {
                            dic[name] = qtyVote;
                        }
                    }
                }
                foreach (var item in dic)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
