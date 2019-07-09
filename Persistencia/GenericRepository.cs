using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Persistencia
{
    public class GenericRepository<T> where T : class
    {
        public virtual void Inserir(T entidade)
        {
            using (var context = new EFContext())
            {
                context.Set<T>().Add(entidade);
                context.SaveChanges();
            }
        }

        public virtual void Atualizar(T entidade)
        {
            using (var context = new EFContext())
            {
                context.Entry(entidade).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public virtual IList<T> ObterTodos()
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().ToList<T>();
            }
        }

        public virtual T ObterPorId(long? ID)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Find(ID);
            }
        }

        public virtual void Remover(long? ID)
        {
            using (var context = new EFContext())
            {
                var entidade = context.Set<T>().Find(ID);
                context.Set<T>().Remove(entidade);
                context.SaveChanges();
            }
        }

        public virtual IList<T> Buscar(Func<T, bool> predicate)
        {
            using (var context = new EFContext())
            {
                return context.Set<T>().Where(predicate).ToList();
            }

        }
    }
}
