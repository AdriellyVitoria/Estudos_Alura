using OrientacaoAoObjeto;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.Titular = "Andre Silva";
contaDoAndre.NumeroAgencia = 15;
contaDoAndre.Conta = "1010-X";
contaDoAndre.Saldo = 100;

Console.WriteLine("Saldo da conta do andre = " + contaDoAndre.Saldo);
Console.WriteLine("Nome do titular: "+ contaDoAndre.Titular);
Console.WriteLine("Numero da agencia: " + contaDoAndre.NumeroAgencia);
Console.WriteLine("A conta é: " + contaDoAndre.Conta);

contaDoAndre.Depositar(100);
Console.WriteLine("Saldo depois do depositor: " + contaDoAndre.Saldo);


if (contaDoAndre.Sacar(300))
{
    Console.WriteLine("O saldo vai ficar: " + contaDoAndre.Saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente: " + contaDoAndre.Saldo);
}
   

