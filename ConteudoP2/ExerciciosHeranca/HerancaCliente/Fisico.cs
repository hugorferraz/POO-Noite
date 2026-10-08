using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{//     classe derivada : classe base/superclasse
    public class Fisico : Cliente
    {
        public int Rg { get; set; }
        public Fisico() : base()
        {            
        }
        public Fisico(int codigo, string? nome, int rg) : base(codigo, nome)
        {
            Rg = rg;
        }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Rg: " + Rg);
        }       
    }
}