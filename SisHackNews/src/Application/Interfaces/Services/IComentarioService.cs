using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Application.Interfaces.Services
{
    public interface IComentarioService
    {
        List<Comentario> GetTodos();

        List<Comentario> GetByNoticia(int noticiaId);

        List<Comentario> Get(Expression<Func<Comentario, bool>> predicate);

        Comentario Procurar(params object[] key);

        Comentario Primeiro(Expression<Func<Comentario, bool>> predicate);

        void Adicionar(Comentario noticia);

        void Atualizar(Comentario noticia);

        void Deletar(Func<Comentario, bool> predicate);
    }
}
