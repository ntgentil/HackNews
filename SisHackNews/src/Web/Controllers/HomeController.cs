using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces.Services;
using Application.Model;
using Application.ViewModel;
using AutoMapper;
using Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoticiaService _noticiaService;
        private readonly IComentarioService _comentarioService;
        private readonly IMapper _mapper;

        public HomeController(INoticiaService noticiaService, IMapper mapper, IComentarioService comentarioService)
        {
            _noticiaService = noticiaService;
            _mapper = mapper;
            _comentarioService = comentarioService;
        }

        public ActionResult Index()
        {
            var noticias = _mapper.Map<List<NoticiaViewModel>>(_noticiaService.GetTodos().ToList());

            return View(noticias);
        }

        public ActionResult Details(int id)
        {
            var noticia = _noticiaService.Procurar(id);
            var comentarios = _comentarioService.GetByNoticia(id);

            var noticiaVm = _mapper.Map<NoticiaViewModel>(noticia);
            var comentariosVm = _mapper.Map<List<ComentarioViewModel>>(comentarios);

            noticiaVm.Comentarios = comentariosVm;

            return View(noticiaVm);
        }

        [HttpPost]
        public ActionResult Comentar(NoticiaViewModel noticiaViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var noticia = _mapper.Map<NoticiaViewModel>(_noticiaService.Procurar(noticiaViewModel.NoticiaId));

                    noticiaViewModel.Comentario.NoticiaViewModel = noticia;

                    var comentario = _mapper.Map<Comentario>(noticiaViewModel.Comentario);

                    comentario.Noticia = _noticiaService.Procurar(noticiaViewModel.NoticiaId);

                    comentario.DataCadastro = DateTime.Now;

                    _comentarioService.Adicionar(comentario);

                    return RedirectToAction(nameof(Details), new { id = noticiaViewModel.NoticiaId });
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Erro ao atualizar notícia, " + "tente novamente.");
            }


            return RedirectToAction(nameof(Details), new { noticiaViewModel.NoticiaId });
        }

        public ActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
