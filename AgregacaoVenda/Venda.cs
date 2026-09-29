using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp { get; set; }
        public Vendedor Vend { get; set; }
        public List<Produto> VetProd { get; set; }

        //Construtor
        public Venda(Comprador comp, Vendedor vend, List<Produto> vetProd)
        {
            Comp = comp;
            Vend = vend;
            VetProd = vetProd;

            EfetuarVenda();
        }
        private void EfetuarVenda()
        {
            double totalVenda = 0;
            foreach (var produto in VetProd)
            {
                totalVenda += produto.Preco;
            }
            Comp.DiminuirVerba(totalVenda);
            Vend.CalcularComissao(totalVenda);
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("\n--- Produtos Vendidos ---");
            foreach (var prod in VetProd)
            {
                prod.MostrarAtributos();
            }

            Console.WriteLine("\n--- Situação do Comprador ---");
            Comp.MostrarAtributos();

            Console.WriteLine("\n--- Situação do Vendedor ---");
            Vend.MostrarAtributos();
        }
    }
}