class ContaCorrente : Conta{
    public decimal limite;

    public ContaCorrente(Cliente cliente) : base(cliente) {}
    
    public ContaCorrente(Cliente cliente, decimal saldo) : base(cliente) {
        this.saldo = saldo;
    }



    public override void Debitar(decimal valor){
        valor += 0.01M;
        base.Debitar(valor);
    }
}