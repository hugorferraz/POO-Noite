using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceIAutenticavel
{ // classe derivada
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (Senha == senha){
                Console.WriteLine("Gerente Validado!");
                return true;
            }
            return false;
        }
    }
}