using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaMensalista
{
    public class Horista : Funcionario
    {
        private int qtdeHorasSemana;
        public int QtdeHorasSemana
        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }

        //Construtor do Horista, repassa os atributos para a super classe 'Funcionario'
        public Horista(int codigo, string? nome, double salario, int qtdeHorasTrabalhadas, int qtdeHorasSemana) : base(codigo, nome, salario, qtdeHorasTrabalhadas)
        {
            this.qtdeHorasSemana = qtdeHorasSemana;
        }

        public override double CalcularSalario(double salario, int qtdeHorasTrabalhadas)
        {
            double salarioCalculado = (salario * qtdeHorasSemana) / 4.5;
            Console.WriteLine($"[Horista] Salário calculado: {salarioCalculado:c}");
            return salarioCalculado;
        }

        public override void Mostrar()
        {
            Console.Write("[HORISTA] ");
            base.Mostrar();
            Console.WriteLine($"Horas por semana: {qtdeHorasSemana}");
        }
        
    }
}