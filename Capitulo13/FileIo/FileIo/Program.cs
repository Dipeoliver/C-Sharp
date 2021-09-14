using System;
using System.IO;

namespace FileIo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\GitHub\FileIo.txt";
            string targetPath = @"C:\GitHub\newFile.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                // copiar arquivo para um novo
                fileInfo.CopyTo(targetPath);
                Console.WriteLine("Cópia com sucesso");
                // --------------------------------------------------

                // ler um arquivo e instanciar um vetor com os itens do arquivo
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }

        }
    }
}
