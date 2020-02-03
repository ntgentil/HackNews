using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Application.Interfaces.Services
{
    public interface INoticiaService
    {
        IQueryable<Noticia> GetTodos();

        List<Noticia> Get(Expression<Func<Noticia, bool>> predicate);

        Noticia Procurar(params object[] key);

        Noticia Primeiro(Expression<Func<Noticia, bool>> predicate);

        void Adicionar(Noticia noticia);

        void Atualizar(Noticia noticia);

        void Deletar(Func<Noticia, bool> predicate);
    }
}
