using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Anti.Padrao
{
    public class EmailService
    {
        public static bool IsValido(string email)
        {
            return email.Contains("@");
        }

        public static string EnviarEmail(string email, string mensagem)
        {
            return $"Para: { email } Mensagem: { mensagem }";
        }
    }
}
