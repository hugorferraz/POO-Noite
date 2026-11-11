using ExercicioOCP;

Funcionario f1 = new Funcionario("José", 5000.0);
Funcionario f2 = new Funcionario("Ana", 2500.0);

ICalculadoraSalarios calcPermanente = new FuncionarioPermanente();
ICalculadoraSalarios calcContrato = new FuncionarioContrato();

double salAjustF1 = calcPermanente.CalcularSalario(f1);
double salAjustF2 = calcContrato.CalcularSalario(f2);

Console.WriteLine($"Funcionário: {f1.Nome} | Base: {f1.Salario:C} | Tipo: Permanente | Final: {salAjustF1:c}");
Console.WriteLine($"Funcionário: {f2.Nome} | Base: {f2.Salario:C} | Tipo: Contrato   | Final: {salAjustF2:c}");