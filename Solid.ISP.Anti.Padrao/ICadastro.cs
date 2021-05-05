using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Anti.Padrao
{
    public interface ICadastro
    {
        void ValidarDados();
        void SalvarBancoDeDados();
        void EnviarEmail();
    }
}