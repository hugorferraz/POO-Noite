using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public double Verba { get; set; }
        
        //Construtor que concede um valor inicial no momento da instância.
        public Comprador(double valorIni)
        {
            Verba = valorIni;
        }

        public void DiminuirVerba(double compra)
        {
            Verba = Verba - compra;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Verba disponível: {Verba:c}");
        }
    }
}