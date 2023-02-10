using byteBank_ADM.Funcionarios;
using byteBank_ADM.SistemaInterno;
using byteBank_ADM.Utilitario;

#region 
/*Funcionario pedro = new Funcionario("12345678910", 2000);
pedro.Nome = "Pedro ABC";
//pedro.Salario = 2000.00;
//pedro.SetSalario(2000);
Console.WriteLine(pedro.Nome + ": R$" + pedro.GetBonificacao());


Diretor cleber = new Diretor("98765432109");
cleber.tipo = 1;
cleber.Nome = "Cleber";
//cleber.Salario = 5000.00;
//cleber.SetSalario(10000);
Console.WriteLine(cleber.Nome + ": R$" + cleber.GetBonificacao());


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(cleber);
Console.WriteLine("Total de bonificações: R$" + gerenciador.getBonificacao());

Console.WriteLine("Total de Funcionários:" + Funcionario.TotalDeFuncionarios);
Console.WriteLine("Total de Diretores:" + Diretor.TotalDeDiretores);

pedro.AumentarSalario();
cleber.AumentarSalario();
Console.WriteLine("Pedro:" + pedro.Salario);
Console.WriteLine("Cleber:" + cleber.Salario);*/
#endregion

//CalculaBonificacao();
UsarSistema();

void CalculaBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer designer = new Designer("123");
    designer.Nome = "Ulisses";

    Auxiliar auxiliar = new Auxiliar("456");
    auxiliar.Nome = "Marcos";

    Diretor diretor = new Diretor("789");
    diretor.Nome = "Maria";

    GerenteDeContas gerente = new GerenteDeContas("098");
    gerente.Nome = "Rosângela";

    gerenciador.Registrar(designer);
    gerenciador.Registrar(auxiliar);
    gerenciador.Registrar(diretor);
    gerenciador.Registrar(gerente);

    Console.WriteLine("Total de Funcionários:" + Funcionario.TotalDeFuncionarios);
    Console.WriteLine("Total de Bonificações:" + gerenciador.TotalDeBonificacoes);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor julia = new Diretor("12345678910");
    julia.Nome = "Julia";
    julia.Login = "Julia0102";
    julia.Senha = "123";

    GerenteDeContas frank = new GerenteDeContas("98765432109");
    frank.Nome = "Frank";
    frank.Login = "Frank2601";
    frank.Senha = "456";

    sistema.Logar(julia, "Julia0102", "123");
    sistema.Logar(frank, "Frank2601", "456");
}