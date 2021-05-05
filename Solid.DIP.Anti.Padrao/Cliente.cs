using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Anti.Padrao
{
    public class Cliente
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Cliente(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;

            if (!EmailService.IsValido(Email))
                throw new ArgumentException("E-mail é inválido.");
        }
    }
}
