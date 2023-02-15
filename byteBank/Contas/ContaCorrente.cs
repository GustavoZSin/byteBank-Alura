using byteBank.Titular;

namespace byteBank.Contas
{
    internal class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public static float TaxaOperacao { get; private set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }

        public string Conta { get; set; }

        private double saldo = 100;
        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                throw new SaldoInsuficienteException("Tentativa de saque de valor maior que o saldo");
                //return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(int valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta, int saldo, Cliente titular)
        {
            this.Titular = titular;
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            SetSaldo(saldo);

            if(Numero_agencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual à zero", nameof(numero_agencia));
            }

            /*try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro! Tentativa de divisão por zero!");
            }*/

            TotalDeContasCriadas++;

        }
    }
}