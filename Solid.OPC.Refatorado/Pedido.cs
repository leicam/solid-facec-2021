using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OPC.Refatorado
{
    public class Pedido
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Cliente Cliente { get; private set; }
        public decimal Valor { get; set; }

        public Pedido(Cliente cliente, decimal valor)
        {
            Cliente = cliente;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"Cliente: { Cliente.Nome }, Valor R$: { Valor }";
        }
    }
}