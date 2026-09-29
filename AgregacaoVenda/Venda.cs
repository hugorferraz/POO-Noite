using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp { get; set; }
        public Vendedor vend { get; set; }
        public List<Produto> vetProd { get; set; }
    }
}