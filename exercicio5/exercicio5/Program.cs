using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor em milhas marítimas: ");
            double milhasMaritimas = Convert.ToDouble(Console.ReadLine());

            Conversor conversor = new Conversor();

            double quilometros = conversor.ConverterMilhasParaQuilometros(milhasMaritimas);
            Console.WriteLine($"{milhasMaritimas} milhas marítimas equivalem a {quilometros} quilômetros.");
        }
    }
}
