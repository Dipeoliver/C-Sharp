using System;
using System.Globalization;

namespace Quinto
{
    class Program
    {
        static void Main(string[] args)
        {          

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com os valores do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areafinalx = x.Areatriangulo();

            Console.WriteLine("Entre com os valores do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areafinaly = y.Areatriangulo();

            Console.WriteLine("A area do triangulo X é: " + areafinalx.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do triangulo Y é: " + areafinaly.ToString("F4", CultureInfo.InvariantCulture));

            if (areafinalx > areafinaly) Console.WriteLine("O maior triangulo é o X");
            else Console.WriteLine("O maior triangulo é o Y");
        }        
    }
}
