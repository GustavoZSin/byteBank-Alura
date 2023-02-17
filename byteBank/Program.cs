using byteBank;
using byteBank.Contas;
using byteBank.Titular;

//------------------------------------------------------

/*Cliente cliente3_0 = new Cliente("Robson", "12345678910", "Dev");
ContaCorrente conta3_0 = new ContaCorrente(18, "1010-X", 150, cliente3_0);
Console.WriteLine("Ag:"+conta3_0.Numero_agencia + " | Conta:" + conta3_0.Conta + " | Saldo:" + conta3_0.GetSaldo() + " | Titular:" + cliente3_0.Nome);
Console.WriteLine(ContaCorrente.TaxaOperacao);

Cliente cliente3_1 = new Cliente("Cleber", "09876543210", "Analista");
ContaCorrente conta3_1 = new ContaCorrente(19, "1011-Y", 200, cliente3_1);
Console.WriteLine("Ag:" + conta3_1.Numero_agencia + " | Conta:" + conta3_1.Conta + " | Saldo:" + conta3_1.GetSaldo() + " | Titular:" + cliente3_1.Nome);
Console.WriteLine(ContaCorrente.TaxaOperacao);

Cliente cliente3_2 = new Cliente("Bento", "45678912309", "Tester");
ContaCorrente conta3_2 = new ContaCorrente(20, "1012-Z", 350, cliente3_2); 
Console.WriteLine("Ag:" + conta3_2.Numero_agencia + " | Conta:" + conta3_2.Conta + " | Saldo:" + conta3_2.GetSaldo() + " | Titular:" + cliente3_2.Nome);
Console.WriteLine(ContaCorrente.TaxaOperacao);

Console.WriteLine();
Console.WriteLine("------------------------------------------");
Console.WriteLine();

Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
Console.WriteLine("Total de clientes criados: " + Cliente.TotalDeClientesCriados);*/


/*Cliente cliente3_0 = new Cliente("Robson", "12345678910", "Dev");

try
{
    ContaCorrente conta3_0 = new ContaCorrente(0, "1010-X", 150, cliente3_0);
    conta3_0.Sacar(500);

}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro:"+ ex .ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual à zero.");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo insuficiente!");
    Console.WriteLine(ex.Message);
}*/

//------------------------------------------------------
LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt");

try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch (IOException Ex)
{
    Console.WriteLine("Leitura de arquivo interrompida");
}
finally
{
    leitor.Dispose();
}