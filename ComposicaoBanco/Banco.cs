using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public List<Poupanca> Poups { get; set; }
        public List<ContaCorrente> Contas { get; set; }

        //Construtor
        public Banco()
        {
            Contas = new List<ContaCorrente>();
            Poups = new List<Poupanca>();
        }
        
        public void IniciarBanco()
        {
            Console.WriteLine("Banco em operação!");
        }
        public void AbrirConta(double saldoInicial, double chequeEspecial)
        {
            //O próprio banco instancia o objeto.
            ContaCorrente novaConta = new ContaCorrente(saldoInicial, chequeEspecial);
            Contas.Add(novaConta);
            Console.WriteLine("Nova Conta Corrente aberta!");
        }
        public void AbrirPoupanca(double saldoInicial)
        {
            Poupanca novaPoupanca = new Poupanca(saldoInicial);
            Poups.Add(novaPoupanca);
            Console.WriteLine("Nova Poupança aberta!");
        }
        public void DecretarFalencia()
        {
            Console.WriteLine("FALÊNCIA DECRETADA!");
            Contas.Clear();
            Poups.Clear();
            Console.WriteLine("Todas as contas foram encerradas!");    
        }

        public void Mostrar()
        {
            Console.WriteLine($"Total de Contas Correntes: {Contas.Count}");
            foreach (var cc in Contas)
            {
                cc.Mostrar();
            }

            Console.WriteLine($"Total de Poupanças: {Poups.Count}");
            foreach (var p in Poups)
            {
                p.Mostrar();
            }
        }

        ~Banco()
        {
            Console.WriteLine("Destrutor do Banco...");
        }
    }
}