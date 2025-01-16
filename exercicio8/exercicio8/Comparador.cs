using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    public class Comparador
    {
        public string ObterMaior(double valor1, double valor2)
        {
            if (valor1 > valor2)
            {
                return $"O maior valor é: {valor1}";
            }
            else if (valor2 > valor1)
            {
                return $"O maior valor é: {valor2}";
            }
            else
            {
                return "Os números são idênticos.";
            }
        }
    }
}
