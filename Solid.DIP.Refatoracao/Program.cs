using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Refatoracao
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ClienteService(new EmailService());
            var cliente = new Cliente("Juliano", "juliano@mail.com");

            if (service.IsValido(cliente))
                Console.WriteLine($"Cliente: { cliente.Nome } é válido");
            else
                Console.WriteLine($"Cliente: { cliente.Nome } é inválido");
        }
    }
}
