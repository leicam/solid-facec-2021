﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Anti.Padrao
{
    public class Pedido
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Cliente Cliente { get; private set; }

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
        }
    }
}