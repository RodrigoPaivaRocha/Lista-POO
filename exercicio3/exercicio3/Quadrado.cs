using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    public class Quadrado
    {
        public double Diagonal { get; set; }

        public Quadrado(double diagonal)
        {
            Diagonal = diagonal;
        }

        public double CalcularArea()
        {
            return (Diagonal * Diagonal) / 2;
        }
    }
}
