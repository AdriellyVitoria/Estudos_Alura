namespace OrientacaoAoObjeto;

public class ContaCorrente
{
    public int NumeroAgencia;
    public string Conta;
    public string Titular;
    public double Saldo;
    
    public void Depositar(double valor)
    {
        this.Saldo += valor;

    }

    public bool Sacar(double valor)
    {
       if (valor <= this.Saldo)
        {
            this.Saldo = valor;
            return true;
        }  
        else
        {
            return false;
        }  
    }


}
