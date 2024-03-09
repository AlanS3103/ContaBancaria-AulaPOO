class ContaPoupanca : Conta, IContaInvestimento
{
    public ContaPoupanca(Cliente cliente, decimal saldo) : base(cliente)
    {
        this.saldo = saldo;
    }

    public void Render()
    {
        var rendimento = GetSaldo() * 0.05M;
        Creditar(rendimento);
    }
}