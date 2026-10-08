using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        protected int codigo;
        protected string? nome;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Cliente()
        {
        }
        public Cliente(int codigo, string? nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + " Nome: " + Nome);
        }        
    }
}