using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Model
{

    [Table("Noticia")]
    public class Noticia
    {
        [Key]
        public int NoticiaId { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Corpo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataPublicacao { get; set; }

        public ICollection<Comentario> Comentarios { get; set; }


    }
}
