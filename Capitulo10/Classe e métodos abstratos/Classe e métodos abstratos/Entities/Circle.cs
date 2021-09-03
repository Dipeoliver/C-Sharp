
using Classe_e_métodos_abstratos.Entities.Enum;
using System;

namespace Classe_e_métodos_abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return (Math.Pow(Radius, 2)) * Math.PI;
        }
    }
}
