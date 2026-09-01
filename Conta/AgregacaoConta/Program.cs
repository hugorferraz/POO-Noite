using AgregacaoConta;
// Main()
Cliente cli = new Cliente("Ana",123);
cli.Mostrar();

Conta c1 = new Conta(1, 100);
//efetivação da agregação
c1.Titular = cli;
c1.Mostrar();

Conta c2 = new Conta(2, 200);
c2.Titular = new Cliente("Bia", 124);
c2.Mostrar();