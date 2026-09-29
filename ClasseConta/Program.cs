using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exemplos de instâncias....");
        //declaração da variável c1, do tipo Conta-classe
        Conta c1;
        //instancia de um objeto
        //c1 esta recebendo uma alocação de memória com
        //a instrução new e chamando o construtur da 
        //classe Conta()
        c1 = new Conta();
        //Como utilizar o objeto?
        c1.numero = 19;
        c1.titular = "Ana";
        c1.saldo = 1009.81;
        //antigamente você chamava a função
        //agora, nós enviamos uma mensagem para o objeto agir
        c1.MostrarAtributos();
        Console.Write("Informe o valor a sacar: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        //saque é um argumento da função/metodo
        c1.Sacar(saque);
        c1.MostrarAtributos();
        //Console.WriteLine($"Número: {c1.numero} \tTitular: {c1.titular} \tSaldo {c1.saldo:c}");

        //Exemplo com digitação
        //instanciação do objeto c2
        Conta c2 = new Conta();
        Console.Write("Informe o número: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o titular: ");
        c2.titular = Console.ReadLine();
        Console.Write("Informe o saldo: ");
        c2.saldo = Convert.ToDouble(Console.ReadLine());
        c2.MostrarAtributos();
        Console.Write("Informe o valor a depositar: ");
        double deposito = Convert.ToDouble(Console.ReadLine());
        //saque é um argumento da função/metodo
        c2.Depositar(deposito);
        c2.MostrarAtributos();
        c2.Tranferir(10,c1);
        c2.MostrarAtributos();
        c1.MostrarAtributos();
    }
}