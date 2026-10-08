using HerancaCliente;

Cliente cli1 = new Cliente();
cli1.Codigo = 1;
cli1.Nome = "Ana";
cli1.Mostrar();
//cli1.Mostrar();

Cliente cli2 = new Cliente(21,"Lia");
cli2.Mostrar();

Fisico f1 = new Fisico();
f1.Codigo = 2;
f1.Nome = "Bia";
f1.Rg = 200;
f1.Mostrar();

Fisico f2 = new Fisico(23,"Teo",230);
f2.Mostrar();