using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Anti.Padrao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Produto não tem e-mai. E agora?????
            throw new NotImplementedException("Este método não é necessário para está classe!");
        }

        public void SalvarBancoDeDados()
        {
            // Persistencia na tabela de Produto
            throw new NotImplementedException();
        }

        public void ValidarDados()
        {
            // Validar Código de Barras EAN
            // Validar Descrição
            // Validar Valor
            throw new NotImplementedException();
        }
    }
}
