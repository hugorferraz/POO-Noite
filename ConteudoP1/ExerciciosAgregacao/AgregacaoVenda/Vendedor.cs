using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }

        public void CalcularComissao(double preco){
            Comissao = Comissao + (preco * 0.02);
        }

        public void MostrarAtributos(){
            Console.WriteLine($"Comissão do Vendedor: {Comissao:c}");
        }
    }
}