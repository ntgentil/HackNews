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
    public class NoticiaService : INoticiaService
    {
        private readonly INoticiaRepository _noticiaRepository;

        public NoticiaService(INoticiaRepository noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;

        }

        public void Adicionar(Noticia noticia)
        {
            _noticiaRepository.Adicionar(noticia);
            _noticiaRepository.Commit();
        }

        public void Atualizar(Noticia noticia)
        {
            _noticiaRepository.Atualizar(noticia);
            _noticiaRepository.Commit();
        }

        public void Deletar(Func<Noticia, bool> predicate)
        {
            _noticiaRepository.Deletar(predicate);
            _noticiaRepository.Commit();
        }

        public List<Noticia> Get(Expression<Func<Noticia, bool>> predicate)
        {
            return _noticiaRepository.Get(predicate).ToList();
        }

        public IQueryable<Noticia> GetTodos()
        {
            return _noticiaRepository.GetTodos();
        }

        public Noticia Primeiro(Expression<Func<Noticia, bool>> predicate)
        {
            return _noticiaRepository.Primeiro(predicate);
        }

        public Noticia Procurar(params object[] key)
        {
            return _noticiaRepository.Procurar(key);
        }
    }
}
