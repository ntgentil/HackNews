using Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel
{
    public class ComentarioViewModel
    {
        public int ComentarioId { get; set; }
        public int NoticiaId { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public NoticiaViewModel NoticiaViewModel { get; set; }
    }
}
