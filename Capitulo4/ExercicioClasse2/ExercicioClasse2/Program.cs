using System;
using System.Globalization;

namespace ExercicioClasse2
{
    class Program
    {

        static void Main(string[] args)
        {
            Retangulo rec = new Retangulo();
        
 


            Console.WriteLine("Entre a largura e altura do retângulo: ");

            rec.Altura = double.Parse(Console.ReadLine());
            rec.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine(); ;

            Console.WriteLine($"AREA = {rec.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {rec.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {rec.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");




        }
    }
}
