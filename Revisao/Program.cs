internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.Write("Digite seu ano de nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        int idade = 2026 - ano;
        Console.WriteLine("Sua idade é " + idade + " anos.");
        //Estrutura de decisão/seleção
        if (idade >= 18)
            Console.WriteLine("Maior idade");
        else if (idade == 1)
            Console.WriteLine("Só tem um ano de idade");
        else
            Console.WriteLine("Menor idade");
        int epoca = 2;
        switch (epoca)
        {
            case 1: Console.WriteLine("Verão");
                    break;
            case 2: Console.WriteLine("Outono");
                    break;
            default: Console.WriteLine("Opção inválida!");
                     break;
        }*/
        //estrutura de repetição while
        int cont = 1;
        while (cont <= 10)
        {
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
            cont = cont + 1;
        }  
        Console.WriteLine("FOR..............");
        for (cont = 1; cont <= 10; cont ++)    
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
        cont = 1;
        do
        {
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
            cont += 1;
        } while (cont <= 10);
        Console.WriteLine("DECREMENTO......");
        cont = 10;
        while (cont >= 1)
        {
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
            cont = cont - 1;
        }
        Console.WriteLine("DECREMENTO......for...");
        for (cont = 10; cont >= 1; cont --)
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
    }
}