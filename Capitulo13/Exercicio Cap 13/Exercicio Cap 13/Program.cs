using System;
using System.IO;

namespace Exercicio_Cap_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\in\input.csv";
            string targetpath = @"C:\in\out\out.csv";
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    string[] lines = File.ReadAllLines(path);

                    using (StreamWriter sw = File.AppendText(targetpath))
                    {
                        foreach (string line in lines)
                        {
                            sw.WriteLine(line);
                        }
                    }                   
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
