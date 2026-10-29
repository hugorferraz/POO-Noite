using InterfaceITributavel;

ContaCorrente cc = new ContaCorrente(1000.0);       // Saldo de 1000 -> Imposto de 5% = 50.0
SeguroDeVida seguro = new SeguroDeVida(50000.0);     // Apólice de 50.000 -> Imposto fixo = 75.0

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

totalizador.Adiciona(cc);
totalizador.Adiciona(seguro);

Console.WriteLine("--- Cálculo Individual de Tributos ---");
Console.WriteLine($"Tributo da Conta Corrente (Saldo: {cc.Saldo:c}): {cc.CalcularTributos():c}");
Console.WriteLine($"Tributo do Seguro de Vida (Valor: {seguro.ValorSeguro:c}): {seguro.CalcularTributos():c}");

Console.WriteLine("\n--- Total Acumulado ---");
Console.WriteLine($"Total geral de impostos a pagar: {totalizador.Total:C}");