using byteBank_ADM.Funcionarios;
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

CalculaBonificacao();

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
