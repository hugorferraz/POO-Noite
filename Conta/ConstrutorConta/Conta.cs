using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        //encapsulamento compacto
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public double Saldo { get; set; }
        public static int Contador { get; set; }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero}   Titular: {Titular}  Saldo {Saldo:c}");
        }
        public Conta()//construtor padrão
        {   //contagem - incremento
            Contador = Contador + 1;
        }
        public Conta(int numero)
        { //   atributo = parâmetro
            this.Numero = numero;
            Contador = Contador + 1;
        }
        public Conta(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
            Contador = Contador + 1;
        }
    }
}