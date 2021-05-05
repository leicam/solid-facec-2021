using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Anti.Padrao
{
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            // disparar um e-mail para o cliente
            throw new NotImplementedException();
        }

        public void SalvarBancoDeDados()
        {
            // persistir no banco de dados
            throw new NotImplementedException();
        }

        public void ValidarDados()
        {
            // Validar CPF e Validar E-mail
            throw new NotImplementedException();
        }
    }
}
