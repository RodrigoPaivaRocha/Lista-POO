using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da aresta do quadrado: ");
            double aresta = Convert.ToDouble(Console.ReadLine());

            Quadrado quadrado = new Quadrado(aresta);

            double area = quadrado.CalcularArea();
            Console.WriteLine($"A área do quadrado é: {area}");
        }
    }
}
