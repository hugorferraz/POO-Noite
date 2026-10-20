using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(int codigo, string? nome, int idade){
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public abstract void VerificarIdade();
        public virtual void Mostrar(){
            Console.WriteLine("Código: " + Codigo + "Nome: " + Nome + "Idade: " + Idade);
        }
    }
}