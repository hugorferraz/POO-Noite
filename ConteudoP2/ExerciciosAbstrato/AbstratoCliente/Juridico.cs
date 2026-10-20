using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class Juridico: Cliente
    {
        public int Cnpj { get; set; }
        public Juridico(int codigo, string? nome, int idade, int cnpj): base(codigo, nome, idade) {
            Cnpj = cnpj;
        }

        public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("Cnpj: " + Cnpj);
        }

        public override void VerificarIdade(){
            if (Idade >= 40)
                Console.WriteLine("Cliente Jurídico.");
        }
    }
}