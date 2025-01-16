using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public bool EhTriangulo()
        {
            return LadoA + LadoB > LadoC &&
                   LadoA + LadoC > LadoB &&
                   LadoB + LadoC > LadoA;
        }

        public bool EhRetangulo()
        {
            if (!EhTriangulo())
                return false;

            double[] lados = { LadoA, LadoB, LadoC };
            Array.Sort(lados);

            double cateto1 = lados[0];
            double cateto2 = lados[1];
            double hipotenusa = lados[2];

            return Math.Abs(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2) - Math.Pow(hipotenusa, 2)) < 1e-6;
        }
    }
}
