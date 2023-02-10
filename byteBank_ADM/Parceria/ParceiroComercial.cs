using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Parceria
{
    internal class ParceiroComercial
    {
        public string Senha { get; set; }
        public bool Autenticar(string login, string senha)
        {
            return this.Senha == senha;
        }
    }
}
