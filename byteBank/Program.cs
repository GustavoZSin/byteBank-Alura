using byteBank.Contas;
using byteBank.Titular;

//------------------------------------------------------

Cliente cliente3_0 = new Cliente("Robson", "12345678910", "Dev");
ContaCorrente conta3_0 = new ContaCorrente(18, "1010-X", 150, cliente3_0);
Console.WriteLine("Ag:"+conta3_0.Numero_agencia + " | Conta:" + conta3_0.Conta + " | Saldo:" + conta3_0.GetSaldo() + " | Titular:" + cliente3_0.Nome);

Cliente cliente3_1 = new Cliente("Cleber", "09876543210", "Analista");
ContaCorrente conta3_1 = new ContaCorrente(19, "1011-Y", 200, cliente3_1);
Console.WriteLine("Ag:" + conta3_1.Numero_agencia + " | Conta:" + conta3_1.Conta + " | Saldo:" + conta3_1.GetSaldo() + " | Titular:" + cliente3_1.Nome);

Cliente cliente3_2 = new Cliente("Bento", "45678912309", "Tester");
ContaCorrente conta3_2 = new ContaCorrente(20, "1012-Z", 350, cliente3_2); 
Console.WriteLine("Ag:" + conta3_2.Numero_agencia + " | Conta:" + conta3_2.Conta + " | Saldo:" + conta3_2.GetSaldo() + " | Titular:" + cliente3_2.Nome);

Console.WriteLine();
Console.WriteLine("------------------------------------------");
Console.WriteLine();

Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
Console.WriteLine("Total de clientes criados: " + Cliente.TotalDeClientesCriados);