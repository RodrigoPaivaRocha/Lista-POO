using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    public class ConversorMoeda
    {
        public double CotacaoDolar { get; set; }

        public double QuantidadeDolares { get; set; }

        public ConversorMoeda(double cotacaoDolar, double quantidadeDolares)
        {
            CotacaoDolar = cotacaoDolar;
            QuantidadeDolares = quantidadeDolares;
        }

        public double ConverterParaReais()
        {
            return CotacaoDolar * QuantidadeDolares;
        }
    }
}
