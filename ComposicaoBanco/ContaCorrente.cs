using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set; }

        //Construtor
        public ContaCorrente(double saldoInicial, double chequeEspecial)
        {
            this.Saldo = saldoInicial;
            this.ChequeEspecial = chequeEspecial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += Saldo;
                Console.WriteLine($"Depósito de {valor:c} realizado!");
            }
            else
                Console.WriteLine("Valor inválido!");
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
                Console.WriteLine("Valor inválido!");
            
            if (valor <= Saldo + ChequeEspecial)
            {
                Saldo -= valor;
                Console.WriteLine($"O saque de {valor:c} foi realizado com sucesso!");
            }
            else
                Console.WriteLine($"Saldo e limite de cheque especial insuficiente!");
        }

        public void GerarExtrato()
        {
            Console.WriteLine("EXTRATO DA CONTA");
            Mostrar();
        }

        public void Mostrar()
        {
            Console.WriteLine($"\nSaldo atual: {Saldo:c} \nCheque especial {ChequeEspecial:c} Saldo Total disponível: {Saldo + ChequeEspecial:c}");
        }
        
        ~ContaCorrente()
        {
            Console.WriteLine("Destrutor da Conta Corrente...");
        }
    }
}