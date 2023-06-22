using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;

namespace ByteBank_ADM.Funcionarios
{
    public class GerenteDeConta : Autenticavel
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}