using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    internal class Auxiliar:Funcionario
    {
        public static int TotalDeAuxiliares { get; private set; }
        public override double GetBonificacao()
        {
            return this.Salario * 0.20;
        }

        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            //Console.WriteLine("Criação de Auxiliar");
            TotalDeAuxiliares++;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}
