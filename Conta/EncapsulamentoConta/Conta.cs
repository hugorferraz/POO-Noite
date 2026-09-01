using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;
        public int Numero
        {
            get { return numero; }
            set { 
                if (value > 0)
                    numero = value; 
            }
        }
        public string? Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo {saldo:c}");
        }           
    }
}