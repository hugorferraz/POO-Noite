using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public List<Funcionario> VetFuncionario { get; set; }

        public Departamento(int codigo, string? nome){
            Codigo = codigo;
            Nome = Nome;
        }

        public void Admitir(Funcionario f){
            VetFuncionario.Add(f);
        }

        public void Listar(){
            foreach (var f in VetFuncionario){
                f.Mostrar();
            }
        }

        public void Demitir(int codigoExclusao){
            for (int i = 0; i < VetFuncionario.Count; i++){
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);
                if (f.Codigo == codigoExclusao)
                {
                    VetFuncionario.Remove(f);
                    Console.WriteLine("\nFuncionário Removido!\n");
                }  
            }
        }

        public double CalcularFolha(int diasUteis){
            double folha = 0;
            for (int i = 0; i < VetFuncionario.Count; i++){
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);
                folha = folha + f.CalcularSalario(diasUteis);
            }
            return folha;
        }
    }
}