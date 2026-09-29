using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private int codigo;
        private string? nome;
        private double preco;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                if (value > 500)
                    codigo = value;
                else
                    Console.WriteLine("O código deve ser a partir de 501");
            }
        }

        public string? Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                if (preco >= 0)
                    preco = value;
                else
                    Console.WriteLine("O preço não pode ser negativo!");
            }   
        }

        //Construtor
        public Produto(int codigo, string nome, double preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }

        public void MostrarAtributos(){
            Console.WriteLine($"Código: {Codigo}\nNome: {Nome} \nPreço: {Preco:c}");
        }
    }
}