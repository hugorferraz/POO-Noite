using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//pasta
namespace ArrayConta
{
    public class Conta
    {
        // declaração de atributos
        public int numero;
        public string titular;
        public double saldo;
        // declaração das funções
        // declaração dos MÉTODOS
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo {saldo:c}");
        }
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {   // saldo = saldo + valorDeposito;
            saldo += valorDeposito;
        }  
        public void Tranferir(double valorTransferencia, Conta objContaDestino)    
        {
            saldo = saldo - valorTransferencia;
            objContaDestino.saldo += valorTransferencia; 
        }  
    }
}