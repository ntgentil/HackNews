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
    public class NoticiaRepository : Repository<Noticia>, INoticiaRepository
    {
        public NoticiaRepository(Context context) : base(context)
        {
        }
    }
}
