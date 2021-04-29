using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OPC.Refatorado
{
    class Program
    {
        static void Main(string[] args)
        {
            var clienteRepository = new ClienteRepository();
            Console.WriteLine(clienteRepository.Entidade.GetType());

            var pedidoRepository = new PedidoRepository();
            Console.WriteLine(pedidoRepository.Entidade.GetType());

            var cliente1 = new Cliente("00000000000", "TESTE UM");

            clienteRepository.Adicionar(cliente1);

            foreach (var cliente in clienteRepository.CarregarTodos())
                Console.WriteLine(cliente.ToString());

            var pedido1 = new Pedido(cliente1, 200.00m);

            pedidoRepository.Adicionar(pedido1);

            foreach (var pedido in pedidoRepository.CarregarTodos())
                Console.WriteLine(pedido.ToString());

            Console.ReadLine();
        }
    }
}