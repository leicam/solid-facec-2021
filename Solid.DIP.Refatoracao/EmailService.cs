using Solid.DIP.Refatoracao.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Refatoracao
{
    public class EmailService : IEmailService
    {
        public string Enviar(string de, string para, string assunto, string mensagem)
        {
            return $"De: { de } \n Para: { para } \n Assunto: { assunto } \n Mensagem: { mensagem }";
        }

        public bool IsValido(string email)
        {
            return email.Contains("@");
        }
    }
}
