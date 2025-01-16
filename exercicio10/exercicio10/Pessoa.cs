using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Pessoa
    {
        public double Peso { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public double CalcularRelacaoPesoAltura()
        {
            return Peso / (Altura * Altura);
        }

        public string ObterMensagemPesoIdeal()
        {
            double relacao = CalcularRelacaoPesoAltura();

            if (relacao < 20)
            {
                return $"Relação: {relacao:F2}. Você está abaixo do peso.";
            }
            else if (relacao >= 20 && relacao < 25)
            {
                return $"Relação: {relacao:F2}. Você está no peso ideal.";
            }
            else
            {
                return $"Relação: {relacao:F2}. Você está acima do peso.";
            }
        }
    }
}
