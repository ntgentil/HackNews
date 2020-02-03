using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel
{
    public class NoticiaViewModel
    {
        public int NoticiaId { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Corpo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataPublicacao { get; set; }
        public List<ComentarioViewModel> Comentarios { get; set; }
        public ComentarioViewModel Comentario { get; set; }
    }
}
