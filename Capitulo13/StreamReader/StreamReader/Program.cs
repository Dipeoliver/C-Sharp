using System;
using System.IO;

namespace StreamReaderCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\GitHub\FileIo.txt";
            StreamReader sr = null;
            try
            {
                // Ler um arquivo através de um stream
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro accurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
