using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OPC.Refatorado
{
    public class Cliente
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Documento { get; set; }
        public string Nome { get; set; }

        public Cliente(string documento, string nome)
        {
            Documento = documento;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Documento: {Documento}, Cliente: { Nome }";
        }
    }
}