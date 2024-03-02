Conta conta = new Conta();

Console.WriteLine(conta.GetSaldo().ToString("c"));

conta.Creditar(100.32M);

Console.WriteLine(conta.GetSaldo().ToString("c"));

try{
    conta.Debitar(150);
}
catch (Exception ex){
    Console.WriteLine(ex.Message);
}


//Console.WriteLine(conta.GetSaldo().ToString("c"));


//Conta Poupança
ContaPoupanca contaPoupanca = new ContaPoupanca();
contaPoupanca.Creditar(100);
contaPoupanca.Debitar(50);
Console.WriteLine($"Saldo na Conta Poupança: {contaPoupanca.GetSaldo().ToString("c")}");


//ContaCorrente
ContaCorrente contaCorrente = new ContaCorrente();
contaCorrente.Creditar(100);
contaCorrente.Debitar(30);
Console.WriteLine($"Saldo na Conta Corrente: {contaCorrente.GetSaldo().ToString("c")}");