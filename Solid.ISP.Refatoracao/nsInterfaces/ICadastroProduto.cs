using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Refatoracao.nsInterfaces
{
    public interface ICadastroProduto
    {
        void ValidarDados();
        void SalvarBancoDados();
    }
}