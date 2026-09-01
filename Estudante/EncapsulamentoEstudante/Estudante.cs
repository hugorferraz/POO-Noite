using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private double media;
        private string? nome;

        public double Media
        {
            set
            {
                if (value >= 0 && value <= 10)
                    this.media = value;
                else
                    Console.WriteLine("Erro: A média deve ser de 0 a 10!");
            }

            get
            {
                return this.media;
            }
        }

        public string? Nome
        {
            set
            {
                this.nome = value?.ToUpper();
            }

            get
            {
                return this.nome;
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"ALUNO: {Nome}");
            Console.WriteLine($"Média: {Media}");
        }

        public bool EstaAprovado()
        {
            if (Media >= 6)
                return true;
            else
                return false;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"ALUNO:{Nome}");
            Console.WriteLine($"MÉDIA: {Media}");
            Console.Write("STATUS: ");
            Console.Write(EstaAprovado() ? "Aprovado" : "Reprovado\n");
        }
    }
}