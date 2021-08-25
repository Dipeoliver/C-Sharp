using System;

namespace SomaComVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Sum.sum( 10, 20, 30, 40, 50, 60);
            Console.WriteLine(s1);



            int a = 10;
            int triple;
            Calc.TripleCalc(a, out triple);
            Console.WriteLine($"{a} * 3 = {triple}");
        }

      
    }
}
