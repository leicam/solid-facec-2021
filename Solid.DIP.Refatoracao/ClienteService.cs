using Solid.DIP.Refatoracao.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Refatoracao
{
    public class ClienteService : IClienteService
    {
        private readonly IEmailService _emailService;

        public ClienteService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public bool IsValido(Cliente cliente)
        {
            return _emailService.IsValido(cliente.Email);
        }
    }
}
