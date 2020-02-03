using Application.Interfaces.Repository;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infra.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Context _context;
        public Repository(Context context)
        {
            _context = context;
        }

        public IQueryable<T> GetTodos()
        {
            var result = _context.Set<T>();
            return result;
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
        public T Procurar(params object[] key)
        {
            return _context.Set<T>().Find(key);
        }

        public T Primeiro(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).FirstOrDefault();
        }
        public void Adicionar(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void Atualizar(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Deletar(Func<T, bool> predicate)
        {
            _context.Set<T>()
           .Where(predicate).ToList()
           .ForEach(del => _context.Set<T>().Remove(del));
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
