using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> VetDependentes { get; set; }

        public Funcionario(int codigo, string? nome, double salario){
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual void Mostrar(){
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} Salário: {Salario:c}");
        }

        public abstract double CalcularSalario(int diasUteis);
        
        public void AdicionarDependente(Dependente novoDep)
        {
            VetDependentes.Add(novoDep);
        }

        public int CalcularTotalDependente()
        {
            VetDependentes.Count;
        }

        public void RemoverDependenteMaiorIdade(int codigo)
        {
            // Busca o dependente pelo código fornecido
            Dependente? dep = VetDependentes.Find(d => d.Codigo == codigo);

            if (dep != null)
            {
                if (dep.VerificarMaiorIdade())
                {
                    VetDependentes.Remove(dep);
                    Console.WriteLine($"Dependente {dep.Nome} removido por ter atingido a maioridade.");
                }
                else
                {
                    Console.WriteLine($"O dependente {dep.Nome} não foi removido pois é menor de idade");
                }
            }

            else
            {
                Console.WriteLine("Dependente não encontrado!");
            }
        }

        public void ListarDependentes()
        {
            Console.WriteLine($"\n Dependentes do Funcionário {Nome}");
            if (VetDependentes.Count == 0)
            {
                Console.WriteLine("Nenhum dependente cadastrado.");
                return;
            }

            foreach (var d in VetDependentes)
            {
                Console.WriteLine($"- Código: {d.Codigo} | Nome: {d.Nome} | Idade: {d.Idade}");
            }
        }
        
    }
}