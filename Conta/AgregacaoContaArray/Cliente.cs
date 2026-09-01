using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaArray
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public int Rg { get; set; }
        public void Mostrar()
        {
            Console.WriteLine("Nome: " + Nome + " Rg: " + Rg);
        }
        public Cliente(string nome, int rg)
        {
            Nome = nome;
            Rg = rg;
        }
    }
}