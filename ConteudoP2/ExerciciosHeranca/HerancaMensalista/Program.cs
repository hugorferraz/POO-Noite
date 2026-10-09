using System.Diagnostics.CodeAnalysis;
using HerancaMensalista;

internal class Program
{
    private static void Main(string[] args)
    {
        //Instacia a superClasse (Funcionario)
        Funcionario f1 = new Funcionario(101, "Zeca", 3000.00, 20);

        //Instancia Mensalista (subClasse)
        Mensalista m1 = new Mensalista(102, "Ana", 4500.00, 30);

        //Instancia Horista (subClasse)
        Horista h1 = new Horista(103, "Daniel", 2500.00, 40, 44);

        Console.WriteLine("FUNCIONÁRIO COMUM");
        f1.Mostrar();
        f1.CalcularSalario();
        Console.WriteLine();

        Console.WriteLine("FUNCIONÁRIO MENSALISTA");
        m1.Mostrar();
        m1.CalcularSalario();
        Console.WriteLine();

        Console.WriteLine("FUNCIONÁRIO HORISTA");
        h1.Mostrar();
        h1.CalcularSalario();
        Console.WriteLine();
    }
}