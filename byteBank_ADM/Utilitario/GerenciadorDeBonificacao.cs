using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBank_ADM.Funcionarios;

namespace byteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacoes { get; private set; }
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacoes += funcionario.GetBonificacao();
        }

        public double getBonificacao()
        {
            return this.TotalDeBonificacoes;
        }
    }
}
