using ByteBank.Funcionarios;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;
using ByteBank_ADM.Funcionarios;
#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro Malarartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);

//Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
#endregion

UsarSistema();

#region
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    
    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987654");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("765363");
    igor.Nome = "Igor Dias";

    GerenteDeConta camila = new GerenteDeConta("3451656");
    camila.Nome = "Camila Alvez";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total De Bonificação = " + gerenciador.TotalDeBonificacao);
#endregion
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("173652");
    ingrid.Nome = "Ingrid Silva";
    ingrid.Senha = "123";

    GerenteDeConta ursula = new GerenteDeConta("345673");
    ursula.Nome = "Ursular Silva";
    ursula.Senha = "345";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");

}
