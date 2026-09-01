using ClasseProduto;
internal class Program
{
    private static void Main(string[] args)
    {                //instância de objeto
        Produto p1 = new Produto();
        p1.MostrarAtributos();
        p1.nome = "Mesa";
        p1.qtde = 10;
        p1.preco = 250;
        p1.MostrarAtributos();
        p1.AdcionarProduto(35);
        p1.MostrarAtributos();
        p1.RemoverProduto(20);
        p1.MostrarAtributos();
        Console.WriteLine($"Total {p1.ValorTotalEstoque():c}");
    

    }
}