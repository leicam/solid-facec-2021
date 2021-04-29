using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OPC.Refatorado
{
    public class ClienteRepository : Repository<Cliente>
    {
        public override void Alterar(Cliente entidade)
        {
            foreach (var item in Entidade)
                if (item.Id.Equals(entidade.Id))
                {
                    //TODO Atualizar as informações
                    item.Documento = entidade.Documento;
                    item.Nome = entidade.Nome;
                    break;
                }
        }
    }
}
