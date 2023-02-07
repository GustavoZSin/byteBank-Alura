using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro ABC";
pedro.CPF = "12345678910";
pedro.Salario = 2500.00;

Console.WriteLine(pedro.Nome + ": R$" + pedro.GetBonificacao());


Diretor cleber = new Diretor();
cleber.tipo = 1;
cleber.Nome = "Cleber";
cleber.CPF = "98765432109";
cleber.Salario = 5000.00;
Console.WriteLine(cleber.Nome + ": R$" + cleber.GetBonificacao());


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(cleber);
Console.WriteLine("Total de bonificações: R$" + gerenciador.getBonificacao());
