using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    public class SeguroDeVida : ITributavel 
    {
        public double ValorSeguro { get; set; }
        public SeguroDeVida(double valorSeguro)
        {
            ValorSeguro = valorSeguro;
        }

        public double CalcularTributos()
        { 
            return 75;
        }
    }
}