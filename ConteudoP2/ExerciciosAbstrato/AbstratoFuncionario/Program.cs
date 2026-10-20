using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bel", 1000);
Comissionado c1 = new Comissionado(1, "Bia", 1000, 0.20);
Comissionado c2 = new Comissionado(1, "Lia", 1000, 0.30);

Departamento d1 = new Departamento(11, "TI");
d1.VetFuncionario = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.Listar();
Console.WriteLine($"Total {d1.CalcularFolha(30):c}");


Departamento d2 = new Departamento(12, "RH");
d2.VetFuncionario = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.Listar();
Console.WriteLine($"Total {d2.CalcularFolha(30):c}");

//d2.Demitir(2); //a2 tem código 2
//d2.Listar();

