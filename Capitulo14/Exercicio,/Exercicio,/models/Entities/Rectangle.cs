using System;
using System.Globalization;
namespace Exercicio_.models.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double height { get; set; }

        public override double Area()
        {
            return Width * height;
        }

        public override string ToString()
        {
            return "The total area is " + Area().ToString("F2", CultureInfo.InvariantCulture) + " and the color is " + color ;
        }
    }
}
