using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(int codigo, string? nome, double salario) : base(codigo, nome, salario)
        {
        }
        public override double CalcularBonificacao()
        {//a palavra override indica a sobrescrita da 
         //lógica do método para o polimorfismo ocorrer
            return Salario * 15 / 100;
        }
    }
}