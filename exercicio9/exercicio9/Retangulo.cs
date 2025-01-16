using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            Base = baseRetangulo;
            Altura = alturaRetangulo;
        }

        public string AvaliarTerreno()
        {
            double area = Base * Altura;
            if (area > 100)
            {
                return $"A área do terreno é {area}. Terreno grande.";
            }
            else
            {
                return $"A área do terreno é {area}. Terreno pequeno.";
            }
        }
    }
}
