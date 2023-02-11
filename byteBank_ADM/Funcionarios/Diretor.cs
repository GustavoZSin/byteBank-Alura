using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public int tipo;
        public static int TotalDeDiretores { get; private set; }

        public override double GetBonificacao()
        {
            return this.Salario * 0.50;
        }

        public Diretor(string cpf) : base(cpf, 5000)
        {
            //Console.WriteLine("Criação de Diretor");
            TotalDeDiretores++;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
