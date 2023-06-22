
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;
using ByteBank_ADM.Funcionarios;

public class SistemaInterno
{
    public bool Logar(Autendivavel  funcionario, string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticar(senha);
        if (usuarioAutenticado)
        {
            Console.WriteLine("Boas-vindas ao nosso sistema.");
            return true;
        }
        else
        {
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }


}  