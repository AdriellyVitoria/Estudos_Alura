
namespace bytebank_ADM.Utilitario;
using bytebank_ADM.Funcionarios;
public class GerenciadorDeBonificacao
{
    public double TotalDeBonificacao { get; private set; }

    public void Registrar(Funcionario funcionario)
    {
        this.TotalDeBonificacao += funcionario.GetBonificacao();
    }

}
