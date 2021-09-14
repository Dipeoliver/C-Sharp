using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\17- Senai Robotica";

            try
            {
                // criar lista enumerada para mostrar as pastas
                // poderia usar assim tb  (IEnumerable<string>).
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("********************************************");
               var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                
                // criar um diretório (Folder)
                Directory.CreateDirectory(path + @"\TesteDiego");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
