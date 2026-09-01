using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private long ra;
        private string? nome;
        private static int contador;

        public long Ra
        {
            set
            {
                this.ra = value;
            }

            get
            {
                return this.ra;    
            }
        }

        public string? Nome
        {
            set
            {
                this.nome = value;
            }

            get
            {
                return this.nome;
            }
        }

        //Acessar o Contador da classe
        public static int Contador
        {
            set
            {
                contador = value;
            }

            get
            {
                return contador;
            }
        }

        static Aluno()
        {
            Contador = 0;
        }

        public Aluno()
        {
            Contador++;
            Ra = 1570482423000L + Contador;
        }

        public Aluno(string nome)
        {
            Contador++;
            Ra = 1570482423000L + Contador;
            Nome = nome;
        }

        public void MostrarAtibutos()
        {
            Console.WriteLine($"RA: {Ra} - Nome: {Nome}");
        }
    }
}