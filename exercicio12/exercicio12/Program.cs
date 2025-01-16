using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite os três lados do triângulo:");
                Console.Write("Lado A: ");
                double ladoA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado B: ");
                double ladoB = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado C: ");
                double ladoC = Convert.ToDouble(Console.ReadLine());

                Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

                if (triangulo.EhTriangulo())
                {
                    if (triangulo.EhRetangulo())
                    {
                        Console.WriteLine("Os valores formam um triângulo retângulo.");
                    }
                    else
                    {
                        Console.WriteLine("Os valores formam um triângulo, mas não é retângulo.");
                    }
                }
                else
                {
                    Console.WriteLine("Os valores não formam um triângulo.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, insira valores numéricos válidos.");
            }
        }
    }
}
