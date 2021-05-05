using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Refatoracao.nsInterfaces
{
    public interface IClienteService
    {
        bool IsValido(Cliente cliente);
    }
}
