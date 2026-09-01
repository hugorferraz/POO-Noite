using ConstrutorAluno;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno alun1 = new Aluno("Primeiro Aluno");
        Aluno alun2 = new Aluno("Segundo Aluno");
        Aluno alun3 = new Aluno("Terceiro Aluno");

        alun1.MostrarAtibutos();
        alun2.MostrarAtibutos();
        alun3.MostrarAtibutos();

        Console.WriteLine("--------------------------");

        Console.WriteLine($"Total de Alunos: {Aluno.Contador}");
    }
}