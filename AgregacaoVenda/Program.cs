using System.Reflection;
using AgregacaoVenda;

internal class Program
{
    private static void Main(string[] args)
    {
        Vendedor vendedor = new Vendedor();
        Comprador comprador = new Comprador(1000.00);

        comprador.MostrarAtributos();
        vendedor.MostrarAtributos();
        Console.WriteLine();

        Produto prod1 = new Produto(501, "Teclado", 150.00);
        Produto prod2 = new Produto(502, "Mouse", 100.00);
        Produto prod3 = new Produto(503, "Monitor", 500.00);

        //VENDA1
        List<Produto> listaVenda1 = new List<Produto> {prod1, prod2}; //Total 250
        Console.WriteLine("Realizando a venda 1...");
        Venda venda1 = new Venda(comprador, vendedor, listaVenda1);
        venda1.MostrarAtributos();

        //VENDA2
        List<Produto> listaVenda2 = new List<Produto> {prod1, prod3}; //Total 650
        Console.WriteLine("Realizando a venda 2...");
        Venda venda2 = new Venda(comprador, vendedor, listaVenda2);
        venda2.MostrarAtributos();

        Console.WriteLine("\nSituação após as 2 vendas...");
        comprador.MostrarAtributos();
        vendedor.MostrarAtributos();
    }
}