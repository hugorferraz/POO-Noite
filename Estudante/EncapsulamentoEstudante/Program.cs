using EncapsulamentoEstudante;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudante est1 = new Estudante();

        Console.Write("Digite o nome do aluno: ");
        est1.Nome = Console.ReadLine();

        Console.Write("Digite a média do aluno: ");
        est1.Media = Convert.ToDouble(Console.ReadLine());

        est1.MostrarAtributos();

        Estudante est2 = new Estudante();

        Console.Write("Digite o nome do aluno: ");
        est2.Nome = Console.ReadLine();

        Console.Write("Digite a média do aluno: ");
        est2.Media = Convert.ToDouble(Console.ReadLine());

        est2.MostrarAtributos();

        est1.EstaAprovado();
        est2.EstaAprovado();

        
        est1.ExibirInformacoes();
        Console.WriteLine("");
        est2.ExibirInformacoes();
    }
}