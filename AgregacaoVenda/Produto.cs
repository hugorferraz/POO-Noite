using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }

        public MostrarAtributos(){
            Console.WriteLine("Código: " + Codigo + "\nNome: " + Nome + "\nPreço: " + Preco);
        }
    }
}