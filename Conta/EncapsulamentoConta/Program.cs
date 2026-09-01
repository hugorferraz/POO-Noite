using EncapsulamentoConta;
// Main()
Conta c1 = new Conta();
//c1.numero = 1; erro devido ao nível de proteção,
//pois está encapsulado com private e get/set
c1.Numero = 1; // usa o set
c1.Titular = "Ana"; // porque tem o caracter de 
c1.Saldo = 100; // atribuição =

Console.WriteLine("Número: " + c1.Numero);//usa o get
c1.MostrarAtributos();