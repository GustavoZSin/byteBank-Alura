using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.SistemaInterno
{
    internal class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string login, string senha)
        {
            bool usuarioLogado = funcionario.Autenticar(login, senha);
            if (usuarioLogado)
            {
                Console.WriteLine("Boas vindas ao sistema");
                return true;
            } else
            {
                Console.WriteLine("Usuário ou senha incorretos");
                return false;
            }
        }
    }
}
