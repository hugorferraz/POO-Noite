using ConstrutorConta;
// Main()
Conta c1 = new Conta();//construtor padrão
c1.MostrarAtributos();
Console.WriteLine("Qtde: " + Conta.Contador);

Conta c2 = new Conta(1, "Ana", 100);
c2.MostrarAtributos();
Console.WriteLine("Qtde: " + Conta.Contador);

Conta c3 = new Conta(19);
c3.MostrarAtributos();
Console.WriteLine("Qtde: " + Conta.Contador);