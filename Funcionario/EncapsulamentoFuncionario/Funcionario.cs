using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int matricula;
        private string? nome;
        private double salario;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
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
        public void MostrarAtributos()
        {
            Console.WriteLine($"Matrícula: {Matricula} \tNome: {Nome} \tSalário {Salario:c}");
        }        
    }
}