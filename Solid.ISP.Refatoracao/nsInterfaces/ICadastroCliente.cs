using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Refatoracao.nsInterfaces
{
    interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarBancoDeDados();
        void EnviarEmail();
    }
}
