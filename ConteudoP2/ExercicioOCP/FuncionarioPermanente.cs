using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ExercicioOCP
{
    public class FuncionarioPermanente : ICalculadoraSalarios
    {
        public double CalcularSalario(Funcionario funcionario)
        {
            return funcionario.Salario * 1.3;
        }
    }
}