using InterfaceIAutenticavel;

Cliente c = new Cliente();
c.Senha = 200;

Gerente g = new Gerente();
g.Senha = 400;

Diretor d = new Diretor();
d.Senha = 300;
//Console.WriteLine("Autenticou? " + d.Autenticar(301));

IAutenticavel ia = d;
Console.WriteLine("Autenticou? " + ia.Autenticar(300));

ia = c;
Console.WriteLine("Autenticou? " + ia.Autenticar(100));