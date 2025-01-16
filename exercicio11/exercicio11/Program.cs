using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os três lados do triângulo:");

            Console.Write("Lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

            string resultado = triangulo.Classificar();
            Console.WriteLine(resultado);
        }
    }
}
