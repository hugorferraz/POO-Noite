using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        public double Saldo { get; set; }
        
        //Construtor
        public Poupanca(double saldoInicial)
        {
            this.Saldo = saldoInicial;
        }
        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
                Console.WriteLine($"O depósito de {valorDeposito:c} foi efetuado com sucesso!");
            }
            else
                Console.WriteLine("Valor de depósito inválido!");
        }
        public void Sacar(double valorSaque)
        {
            if (valorSaque <= 0)
                Console.WriteLine("Valor inválido!");
            if (valorSaque <= Saldo)
            {
                Saldo -= valorSaque;
                Console.WriteLine($"O valor sacado de {valorSaque:c} foi efetuado com sucesso!");
            }
        }
        public void GerarRendimento(double taxa)
        {
            double rendimento = Saldo * (taxa / 100);
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de {taxa}% aplicado!\nValor de rendimento: {rendimento:c}");
        }

        public void Mostrar()
        {
             Console.WriteLine($"\nSaldo da poupança: {Saldo:c}");
        }

        ~Poupanca()
        {
            Console.WriteLine("Destrutor da Poupança...");
        }
    }
}