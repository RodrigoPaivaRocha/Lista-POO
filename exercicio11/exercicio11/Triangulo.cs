using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    public class Triangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public bool EhTriangulo()
        {
            return Lado1 + Lado2 > Lado3 &&
                   Lado1 + Lado3 > Lado2 &&
                   Lado2 + Lado3 > Lado1;
        }

        public string Classificar()
        {
            if (!EhTriangulo())
            {
                return "Os valores não formam um triângulo.";
            }

            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return "Triângulo Equilátero";
            }
            else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
            {
                return "Triângulo Isósceles";
            }
            else
            {
                return "Triângulo Escaleno";
            }
        }
    }
}
