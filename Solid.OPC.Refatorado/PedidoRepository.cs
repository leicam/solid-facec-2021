using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OPC.Refatorado
{
    public class PedidoRepository : Repository<Pedido>
    {
        public override void Alterar(Pedido entidade)
        {
            foreach (var item in Entidade)
                if (item.Id.Equals(entidade.Id))
                {
                    //TODO Atualizar as informações
                    item.Valor = entidade.Valor;
                    break;
                };
        }
    }
}
