using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        public string Login { get; set; }
        public abstract bool Autenticar(string login, string senha);
        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }
    }
}
