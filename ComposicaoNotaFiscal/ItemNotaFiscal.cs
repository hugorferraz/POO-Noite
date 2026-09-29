using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Qtde { get; set; }
        public ItemNotaFiscal(int qtde)
        {
            Qtde = qtde;
        }
        public void Mostrar(){
            Console.WriteLine("Quantidade: " + Qtde);
        }

        ~ItemNotaFiscal(){
            Console.WriteLine("Destrutor do item de nota fiscal!");
        }
    }
}