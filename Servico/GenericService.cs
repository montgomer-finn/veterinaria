using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class GenericService<T> where T : class
    {
        private GenericRepository<T> repositorio = new GenericRepository<T>();
        public void Inserir(T entidade)
        {
            repositorio.Inserir(entidade);
        }

        public void Atualizar(T entidade)
        {
            repositorio.Atualizar(entidade);
        }

        public IList<T> ObterTodos()
        {
            return repositorio.ObterTodos();
        }

        public T ObterPorID(long ID)
        {
            return repositorio.ObterPorId(ID);
        }

        internal void Remover(long? ID)
        {
            repositorio.Remover(ID);
        }
    }
}
