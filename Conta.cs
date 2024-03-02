class Conta
{
    //atributos
    private decimal saldo;

    //métodos
    public decimal GetSaldo()
    {
        return saldo;
    }

    public void Creditar(decimal valor)
    {
        this.saldo += valor;
    }
    
    public void Debitar(decimal valor)
    {
        //Fail Fast
        if (saldo < valor)
            throw new Exception("Não vai dar não parceiro! Cê tá sem saldo!!");
        this.saldo -= valor;
    }

}