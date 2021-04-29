using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Anti.Padrao
{
    public class Cliente
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Documento { get; private set; }
        public string Nome { get; private set; }

        public Cliente(string documento, string nome)
        {
            Documento = documento;
            Nome = nome;
        }
    }
}
