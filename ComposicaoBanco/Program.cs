using ComposicaoBanco;

internal class Program
{
    private static void Main(string[] args)
    {
        //Instancia do Banco
        Banco banco = new Banco();
        banco.IniciarBanco();

        Console.WriteLine("Abertura de Contas...\n");
        banco.AbrirConta(500.00, 200.00);
        banco.AbrirConta(1000.00, 500.00);

        banco.AbrirPoupanca(1500.00);
        banco.AbrirPoupanca(3000.00);

        banco.Mostrar();

        Console.WriteLine("Movimentações...\n");
        banco.Contas[0].Depositar(300.00);
        banco.Contas[0].Sacar(900.00);
        banco.Poups[0].Sacar(200.00);
        banco.Poups[0].GerarRendimento(1);
        banco.Mostrar();    

        banco.DecretarFalencia();

        banco = null;
        GC.Collect();
    }
}