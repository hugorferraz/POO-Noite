using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioSRP
{
    public class GeradorRelatorios
    {
        public string GeradorRelatorio(Conta conta)
        {
            Console.WriteLine($"\nRELATÓRIO");
            return $"Titular: {conta.Titular}\tSaldo: {conta.Saldo:c}";
        }
    }
}