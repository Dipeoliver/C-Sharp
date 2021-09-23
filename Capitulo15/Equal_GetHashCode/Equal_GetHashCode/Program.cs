using Equal_GetHashCode.Entities;
using System;

namespace Equal_GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee() { Name = "Diego", Email = "diego@gmail.com" };
            Employee b = new Employee() { Name = "Joao", Email = "joao@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
