// Main()
using HerancaFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
Secretario s = new Secretario(2, "Bel", 1000);
Gerente g = new Gerente(3, "Bia", 1000);
Diretor d = new Diretor(4, "Lia", 1000);
f.Mostrar();
Console.WriteLine($"Bonificação funcionário {f.CalcularBonificacao()}");

s.Mostrar();
Console.WriteLine($"Bonificação secretário {s.CalcularBonificacao()}");

g.Mostrar();
Console.WriteLine($"Bonificação gerente {g.CalcularBonificacao()}");

d.Mostrar();
Console.WriteLine($"Bonificação diretor {d.CalcularBonificacao()}");