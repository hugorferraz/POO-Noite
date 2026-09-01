using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        //Aqui no atributo/propriedade Titular, 
        //estabelece a agregação
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Numero: {Numero} Saldo {Saldo:c}");
            Titular.Mostrar();
        }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
    }
}