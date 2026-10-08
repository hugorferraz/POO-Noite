using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConteudoP2.ExerciciosHeranca.HerancaMensalista
{
    public class Mensalista : Funcionario
    {
        //Construtor do Mensalista e também chama o construtor da superClasse pai usando a palavra 'base'
        public Mensalista(int codigo, string? nome, double salario, int qtdeHorasTrabalhadas) : base(codigo, nome, salario, qtdeHorasTrabalhadas)
        {
        }

        // Sobrescreve o método CalcularSalario da classe pai (polimorfismo)
        public override double CalcularSalario()
        {
            double salarioCalculado = (salario * qtdeHorasTrabalhadas) / 30.0;
            Console.WriteLine($"[Mensalista] Salário calculado: {salarioCalculado:c}");
            return salarioCalculado;
        }

        public override void Mostrar()
        {
            Console.WriteLine("[MENSALISTA] ");
            base.Mostrar();
        }
    }
}