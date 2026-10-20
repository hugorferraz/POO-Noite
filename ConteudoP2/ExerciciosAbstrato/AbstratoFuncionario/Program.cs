using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bel", 1000);
Comissionado c1 = new Comissionado(1, "Bia", 1000, 0.20);
Comissionado c2 = new Comissionado(1, "Lia", 1000, 0.30);

Dependente dep1 = new Dependente(101, "Lucas", 12);
Dependente dep2 = new Dependente(102, "Marcos", 19);
Dependente dep3 = new Dependente(103, "Júlia", 8);

a1.AdicionarDependente(dep1);
a1.AdicionarDependente(dep2);
c1.AdicionarDependente(dep3);

a1.ListarDependentes();

Console.WriteLine("\nRemoção por Maioridade");
a1.RemoverDependenteMaiorIdade(102);    // Marcos (19 anos) -> Deve remover
a1.RemoverDependenteMaiorIdade(101);    // Lucas (12 anos) -> Não deve remover
a1.ListarDependentes();

Departamento d1 = new Departamento(11, "TI");
d1.Admitir(a1);
d1.Admitir(c1);

Console.WriteLine("\n--- Funcionários do Departamento TI ---");
d1.Listar();
Console.WriteLine($"Total da Folha: {d1.CalcularFolha(30):c}");
d1.MostrarQtdeDependentesFuncionario();

Departamento d2 = new Departamento(12, "RH");
d2.Admitir(a2);
d2.Admitir(c2);

Console.WriteLine("\n--- Funcionários do Departamento RH ---");
d2.Listar();
Console.WriteLine($"Total da Folha: {d2.CalcularFolha(30):c}");
d2.MostrarQtdeDependentesFuncionario();

Console.WriteLine("\n--- Demissão no RH ---");
d2.Demitir(2); // Demite a2 (Bel)
d2.Listar();

