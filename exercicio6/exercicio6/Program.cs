using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da cotação do dólar: ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares: ");
            double quantidadeDolares = Convert.ToDouble(Console.ReadLine());

            ConversorMoeda conversor = new ConversorMoeda(cotacaoDolar, quantidadeDolares);

            double valorEmReais = conversor.ConverterParaReais();
            Console.WriteLine($"O valor correspondente em reais é: R$ {valorEmReais:F2}");
        }
    }
}
