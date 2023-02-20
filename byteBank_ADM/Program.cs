using byteBank_ADM.Funcionarios;
using byteBank_ADM.Parceria;
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

/*//CalculaBonificacao();
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

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "123";
    sistema.Logar(caio, "Caio", "123");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Teste");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Teste");

}*/

//TestaArrayInt();

void TestaArrayInt()
{
    int[] idades = new int[5];

    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine("Tamanho: " + idades.Length);

    int soma = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine("Idade: " + idade);
        soma += idade;
    }
    int media = soma / idades.Length;
    Console.WriteLine("Média: " + media);
}


//TestaBuscaPalavra();

void TestaBuscaPalavra()
{
    string[] stringArray = new string[5];

    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine("Digite a " + (i + 1) + "ª palavra:");

        stringArray[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser buscada.");
    var busca = Console.ReadLine();

    foreach (var palavra in stringArray)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine("Palavra:" + busca);
            break;
        }
    }
}


Array amostra = new double[5];
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array vazio");
    }
    else
    {
        double[] numerosOrdenados = (double[])array.Clone();
        Array.Sort(numerosOrdenados);

        int tamanho = numerosOrdenados.Length;
        int meio = tamanho / 2;
        double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

        Console.WriteLine("Mediana calculada com os dados é: " + mediana);
    }
}



double[] amostraMedia = new double[5];
amostraMedia.SetValue(5.9, 0);
amostraMedia.SetValue(1.8, 1);
amostraMedia.SetValue(7.1, 2);
amostraMedia.SetValue(10, 3);
amostraMedia.SetValue(6.9, 4);

Console.WriteLine(CalculaMedia(amostraMedia).ToString("N2"));

double CalculaMedia(double[] lista)
{
    double media = 0;

    if ((lista == null) || (lista.Length == 0))
    {
        Console.WriteLine("Array vazio");
    }
    else
    {
        double sum = 0;
        for (int i = 0; i < lista.Length; i++)
        {
            sum = sum + lista[i];
        }

        media = sum / 2;
    }
    return media;
}