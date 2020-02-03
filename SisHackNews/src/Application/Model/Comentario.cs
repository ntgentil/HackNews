using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Model
{
    [Table("Comentario")]
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public int NoticiaId { get; set; }

        [ForeignKey("NoticiaId")]
        public Noticia Noticia { get; set; }

    }
}
