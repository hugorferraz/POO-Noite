using ArrayConta;
//declaração de vetor de contas com 3 índices
Conta[] vetConta = new Conta[3];
Console.WriteLine("Cadastro de contas....");
for(int i = 0; i < 3; i++)
{
    vetConta[i] = new Conta();
    Console.Write("Digite o número: ");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    vetConta[i].titular = Console.ReadLine();
    Console.Write("Digite o saldo: ");
    vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
}
// Calcule a soma dos saldos
foreach (Conta c in vetConta)
    c.MostrarAtributos();
for (int i = 0; i < 3; i++)
    vetConta[i].MostrarAtributos();