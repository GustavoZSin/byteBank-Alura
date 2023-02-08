using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    internal class Designer:Funcionario
    {
        public static int TotalDeDesigners { get; private set; }
        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public Designer(string cpf) : base(cpf, 3000)
        {
            //Console.WriteLine("Criação de Designer");
            TotalDeDesigners++;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
