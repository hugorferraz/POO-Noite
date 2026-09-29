using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string? Data { get; set; }
        public List<ItemNotaFiscal> VetItem { get; set; }
        public NotaFiscal(int numero, string data, List<ItemNotaFiscal> vetItem){
            NumeroNf = numero;
            Data = data;
            VetItem = vetItem;
        }
        public void Mostrar(){
            Console.WriteLine("Número da nota fiscal: " +NumeroNf + "Data: " + Data);
            foreach (var item in VetItem){
                item.Mostrar();
            }
        }

        ~NotaFiscal(){
            Console.WriteLine("Destrutor da nota fiscal!");
        }
    }
}