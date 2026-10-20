using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class Fisico: Cliente
    {
        public int Rg { get; set; }
        public Fisico(int codigo, string? nome, int idade, int rg): base(codigo, nome, idade){
            Rg = rg;
        }
        public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("Rg: " + Rg);
        }

        public override void VerificarIdade(){
            if (Idade < 40)
                Console.WriteLine("Cliente Físico.");
        }
    }
}