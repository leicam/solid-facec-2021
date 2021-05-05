using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Refatoracao.nsInterfaces
{
    public interface IEmailService
    {
        string Enviar(string de, string para, string assunto, string mensagem);
        bool IsValido(string email);
    }
}
