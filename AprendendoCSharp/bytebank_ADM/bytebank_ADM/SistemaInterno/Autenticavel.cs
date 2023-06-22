
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{

        public class Autenticavel : Funcionario
        {
            public string Senha { get; set; }

        public abstract bool Autenticar(string senha);

            public Autenticavel(string cpf, double salario) : base(cpf, salario)
            {
                
            }
        }
    }
