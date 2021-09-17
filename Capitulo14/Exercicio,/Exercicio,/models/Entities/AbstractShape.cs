using Exercicio_.models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_.models.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color color { get; set; }

        public abstract double Area();
    }
}
