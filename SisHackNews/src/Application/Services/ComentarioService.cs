using Application.Interfaces.Repository;
using Application.Interfaces.Services;
using Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Application.Services
{
    public class ComentarioService : IComentarioService
    {
        private readonly IComentarioRepository _comentarioRepository;

        public ComentarioService(IComentarioRepository comentarioRepository)
        {
            _comentarioRepository = comentarioRepository;

        }

        public void Adicionar(Comentario comentario)
        {
            _comentarioRepository.Adicionar(comentario);
            _comentarioRepository.Commit();
        }

        public void Atualizar(Comentario comentario)
        {
            _comentarioRepository.Atualizar(comentario);
            _comentarioRepository.Commit();
        }

        public void Deletar(Func<Comentario, bool> predicate)
        {
            _comentarioRepository.Deletar(predicate);
            _comentarioRepository.Commit();
        }

        public List<Comentario> Get(Expression<Func<Comentario, bool>> predicate)
        {
            return _comentarioRepository.Get(predicate).ToList();
        }

        public List<Comentario> GetByNoticia(int noticiaId)
        {
            return _comentarioRepository.GetByNoticia(noticiaId);
        }

        public List<Comentario> GetTodos()
        {
            return _comentarioRepository.GetTodos().ToList();
        }

        public Comentario Primeiro(Expression<Func<Comentario, bool>> predicate)
        {
            return _comentarioRepository.Primeiro(predicate);
        }

        public Comentario Procurar(params object[] key)
        {
            return _comentarioRepository.Procurar(key);
        }
    }
}
