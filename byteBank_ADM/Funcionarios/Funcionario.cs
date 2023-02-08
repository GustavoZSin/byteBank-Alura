using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.CPF = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criação de Funcionário:");
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
