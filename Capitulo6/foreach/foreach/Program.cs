using System;
using System.Collections.Generic;

namespace foreach1
{
    class Program
{
    static void Main(string[] args)
    {
            object[] vect = new object[] { "ana", "mario" };

            foreach(object obj in vect)
            {
                Console.WriteLine(obj);
            }

            List<string> MinhaLista= new List<string> { "Mario", "Jose" };
    }
}
}
