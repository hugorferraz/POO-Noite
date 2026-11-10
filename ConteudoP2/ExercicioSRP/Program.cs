using ExercicioSRP;

Conta c1 = new Conta("Zeca");
c1.Deposito(1500);
c1.Sacar(500);
c1.Sacar(1100);

ValidadorUsuarios val1 = new ValidadorUsuarios();
bool uValido = val1.ValidarUsuario(c1, "Zeca");
bool uInvalido = val1.ValidarUsuario(c1, "João");

Console.WriteLine($"\nValidação 'Zeca': {(uValido ? "Aprovado" : "Negado")}");
Console.WriteLine($"Validação 'João': {(uInvalido ? "Aprovado" : "Negado")}");

GeradorRelatorios gerRelat = new GeradorRelatorios();
string relat = gerRelat.GeradorRelatorio(c1);
Console.WriteLine(relat);
