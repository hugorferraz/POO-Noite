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

        public Banco(List<Poupanca> poups, List<ContaCorrente> contas)
        {
            Poups = poups;
            Contas = contas;
        }
        public void IniciarBanco()
        {
            
        }
        public void AbrirConta()
        {
            
        }
        public void AbrirPoupanca()
        {
            
        }
        public void DecretarFalencia()
        {
            
        }
    }
}