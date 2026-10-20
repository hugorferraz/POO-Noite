using AbstratoCliente;

Fisico f = new Fisico(1, "Ana", 20, 999);
f.Mostrar();

Teste t = new Teste();
t.AvaliarIdadeCliente(f);

Juridico j = new Juridico(3, "Empresa", 40, 1000);
t.AvaliarIdadeCliente(j);