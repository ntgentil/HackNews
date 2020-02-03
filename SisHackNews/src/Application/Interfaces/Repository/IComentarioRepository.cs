using Application.Model;
using System.Collections.Generic;

namespace Application.Interfaces.Repository
{
    public interface IComentarioRepository : IRepository<Comentario>
    {
        List<Comentario> GetByNoticia(int noticiaId);
    }
}
