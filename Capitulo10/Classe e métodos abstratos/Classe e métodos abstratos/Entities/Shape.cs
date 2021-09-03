
using Classe_e_métodos_abstratos.Entities.Enum;

namespace Classe_e_métodos_abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
