using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da pessoa (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da pessoa (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(peso, altura);

            Console.WriteLine($"{pessoa.ObterMensagemPesoIdeal()}");
        }
    }
}
