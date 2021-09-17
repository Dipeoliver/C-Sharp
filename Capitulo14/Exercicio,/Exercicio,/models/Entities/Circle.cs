using System;
using System.Globalization;

namespace Exercicio_.models.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }


        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "The total area is " + Area().ToString("F2", CultureInfo.InvariantCulture) + " and the color is " + color;
        }

    }
}
