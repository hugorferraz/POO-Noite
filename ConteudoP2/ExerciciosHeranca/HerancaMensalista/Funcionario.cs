using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaMensalista
{
    public class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected double salario;
        protected int qtdeHorasTrabalhadas;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }
        
        //Construtor da superClasse
        public Funcionario(int codigo, string? nome, double salario, int qtdeHorasTrabalhadas)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
            this.qtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }

        //Método virtual para permitir a redefinição (override) nas subclasses
        public virtual double CalcularSalario()
        {
            double salarioCalculado = (salario * qtdeHorasTrabalhadas) / 30.0;
            Console.WriteLine($"[Funcionário] Salário calculado: {salarioCalculado:c}");
            return salarioCalculado;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {codigo} | Nome: {nome} | Salário Basse: {salario} | Horas trab: {qtdeHorasTrabalhadas}");
        }
    }
}