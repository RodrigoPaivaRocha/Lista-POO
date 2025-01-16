using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    public class Conversor
    {
        public double ConverterMilhasParaQuilometros(double milhasMaritimas)
        {
            double metros = milhasMaritimas * 1852;
            double quilometros = metros / 1000;
            return quilometros;
        }
    }
}
