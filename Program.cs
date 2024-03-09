// Conta conta = new Conta();

// Console.WriteLine(conta.GetSaldo().ToString("c"));

// conta.Creditar(100.32M);

// Console.WriteLine(conta.GetSaldo().ToString("c"));

// try{
//     conta.Debitar(150);
// }
// catch (Exception ex){
//     Console.WriteLine(ex.Message);
// }


//Console.WriteLine(conta.GetSaldo().ToString("c"));


//Conta Poupança
Cliente cliente = new Cliente();
cliente.Nome = "Fulano";

ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 100);
// contaPoupanca.Cliente = cliente;

contaPoupanca.Creditar(100);
contaPoupanca.Debitar(50);
Console.WriteLine($"Saldo na Conta Poupança: {contaPoupanca.GetSaldo().ToString("c")}");
contaPoupanca.Render();
Console.WriteLine(contaPoupanca.Cliente.Nome);
Console.WriteLine($"Saldo na Conta Poupança: {contaPoupanca.GetSaldo().ToString("c")}");


//ContaCorrente
ContaCorrente contaCorrente = new ContaCorrente(cliente);
contaCorrente.Creditar(100);
contaCorrente.Debitar(50);
Console.WriteLine($"Saldo na Conta Corrente: {contaCorrente.GetSaldo().ToString("c")}");


//ContaCorrente
ContaCorrente contaCorrente1 = new ContaCorrente(cliente, 50);
contaCorrente.Creditar(100);
contaCorrente.Debitar(50);
Console.WriteLine($"Saldo na Conta Corrente: {contaCorrente.GetSaldo().ToString("c")}");

List<Conta> contas = new List<Conta>();

contas.Add(contaPoupanca);
contas.Add(contaCorrente);
contas.Add(contaCorrente1);

foreach (var conta in contas)
{
    Console.WriteLine(conta.GetSaldo());

    if (conta is ContaCorrente)
    {
        ContaCorrente cc = (ContaCorrente)conta;
        Console.WriteLine(cc.limite);
    }

}