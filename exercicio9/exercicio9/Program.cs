using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

            string resultado = retangulo.AvaliarTerreno();
            Console.WriteLine(resultado);
        }
    }
}
