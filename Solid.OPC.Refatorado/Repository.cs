using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OPC.Refatorado
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public List<T> Entidade { get; private set; } = new List<T>();

        public void Adicionar(T entidade) => Entidade.Add(entidade);
        public abstract void Alterar(T entidade);
        public List<T> CarregarTodos() => Entidade;
        public void Remover(T entidade) => Entidade.Remove(entidade);
    }
}