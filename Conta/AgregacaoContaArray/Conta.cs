using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaArray
{
    public class Conta
    {
        public int Numero { get; set; }
        //Aqui no atributo/propriedade Titular, 
        //estabelece a agregação
        public List <Cliente> VetTitulares { get; set; }
        public double Saldo { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Numero: {Numero} Saldo {Saldo:c}");
        }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
    }
}