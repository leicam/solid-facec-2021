using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Anti.Padrao
{
    public class Repositorio
    {
        public List<Pedido> _pedidos = new List<Pedido>();
        public List<Cliente> _clientes = new List<Cliente>();

        public List<Pedido> CarregarTodosPedidos() => _pedidos;
        public List<Cliente> CarregarTodosClientes() => _clientes;

        public void Salvar(Pedido pedido)
        {
            _pedidos.Add(pedido);
        }

        public void Salvar(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public void Alterar(Pedido pedido)
        {
            Pedido pedidoDB;

            foreach(var item in _pedidos)
                if(item.Id.Equals(pedido.Id))
                {
                    pedidoDB = item;
                    break;
                }

            //TODO Atualizar as informações
        }

        public void Alterar(Cliente cliente)
        {
            Cliente clienteDB;

            foreach (var item in _clientes)
                if (item.Id.Equals(cliente.Id))
                {
                    clienteDB = item;
                    break;
                }

            //TODO Atualizar as informações
        }

        public void Remover(Pedido pedido)
        {
            _pedidos.Remove(pedido);
        }

        public void Remover(Cliente cliente)
        {
            _clientes.Remove(cliente);
        }
    }
}