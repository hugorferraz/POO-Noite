using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //declaração de atributos
        public string nome;
        public int qtde;
        public double preco;
        //declaração de métodos
        public void AdcionarProduto(int qtd)
        { //atributo      parâmetro-variável externa
            qtde = qtde + qtd;
        }
        public void RemoverProduto(int qtd)
        {
            qtde -= qtd;
        }
        public double ValorTotalEstoque()
        {
            return qtde * preco;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome: {nome} \tQtde: {qtde} \tPreço {preco:c}");
        }
    }
}