using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        //encapsulamento compacto prop - faz o get/set 
        //de forma implícita, como foi demonstrado
        //no site http://sharplab.io
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tPreço {Preco:c}");
        }
    }
}