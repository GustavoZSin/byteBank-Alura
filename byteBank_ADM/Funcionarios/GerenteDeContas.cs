using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class GerenteDeContas : Autenticavel
    {
        public int tipo;
        public static int TotalDeGerentes { get; private set; }
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            //Console.WriteLine("Criação de Gerente");
            TotalDeGerentes++;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override bool Autenticar(string login, string senha)
        {
            return (this.Login == login && this.Senha == senha);
        }
    }
}
