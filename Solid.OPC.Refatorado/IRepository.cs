using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OPC.Refatorado
{
    public interface IRepository<T> where T : class
    {
        void Adicionar(T entidade);
        void Remover(T entidade);
        void Alterar(T entidade);
        List<T> CarregarTodos();
    }
}