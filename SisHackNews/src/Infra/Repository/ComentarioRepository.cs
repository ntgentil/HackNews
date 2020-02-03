using Application.Interfaces.Repository;
using Application.Model;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infra.Repository
{
    public class ComentarioRepository : Repository<Comentario>, IComentarioRepository
    {
        private readonly Context _context;
        public ComentarioRepository(Context context) : base(context)
        {
            _context = context;
        }

        public List<Comentario> GetByNoticia(int noticiaId)
        {
            return _context.Comentarios.Where(n => n.NoticiaId == noticiaId).ToList();
        }
    }
}
