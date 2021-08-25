using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("O valor de X e nulo");

            if ( y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("O valor de Y e nulo");

            y = x ?? 35.00;

            Console.WriteLine(y.Value);





        }
    }
}
