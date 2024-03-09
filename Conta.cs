abstract class Conta
{
    //atributos
    protected decimal saldo;
    public readonly Cliente Cliente;

    // contrutor:
    public Conta(Cliente Cliente){
        this.Cliente = Cliente;
    }

    //métodos
    public decimal GetSaldo()
    {
        return saldo;
    }

    public void Creditar(decimal valor)
    {
        this.saldo += valor;
    }
    
    public virtual void Debitar(decimal valor)
    {
        //Fail Fast
        if (saldo < valor)
            throw new Exception("Não vai dar não parceiro! Cê tá sem saldo!!");
        this.saldo -= valor;
    }
    // public abstract void Tranferir(decimal valor);
}