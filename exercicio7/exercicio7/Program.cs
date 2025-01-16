using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Comparador comparador = new Comparador();

            double maiorValor = comparador.ObterMaior(valor1, valor2);
            Console.WriteLine($"O maior valor é: {maiorValor}");
        }
    }
}
