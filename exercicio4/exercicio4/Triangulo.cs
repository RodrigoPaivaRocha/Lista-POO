using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    public class Triangulo
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            Base = baseTriangulo;
            Altura = alturaTriangulo;
        }

        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
