using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Application.Model;
using Infra.Data;
using Application.Interfaces.Services;
using AutoMapper;
using Application.ViewModel;

namespace Web.Controllers
{
    public class NoticiasController : Controller
    {
        private readonly INoticiaService _noticiaService;
        private readonly IMapper _mapper;

        public NoticiasController(INoticiaService noticiaService, IMapper mapper)
        {
            _noticiaService = noticiaService;
            _mapper = mapper;
        }

        // GET: Noticias
        public async Task<IActionResult> Index(string ordem, string pesquisar, string currentFilter, int? pageNumber)
        {

            ViewData["CurrentSort"] = ordem;
            ViewData["OrdemDataCadastro"] = String.IsNullOrEmpty(ordem) ? "data_cadastro_desc" : "";
            ViewData["OrdemDataPublicacao"] = ordem == "data_publicacao" ? "data_publicacao_desc" : "data_publicacao";
            ViewData["PesquisarFiltro"] = pesquisar;

            if (pesquisar != null)
            {
                pageNumber = 1;
            }
            else
            {
                pesquisar = currentFilter;
            }

            ViewData["CurrentFilter"] = pesquisar;

            var noticias = _noticiaService.GetTodos();

            if (!String.IsNullOrEmpty(pesquisar))
            {
                noticias = noticias.Where(s => s.Titulo.Contains(pesquisar));
            }

            switch (ordem)
            {
                case "data_cadastro":
                    noticias = noticias.OrderBy(s => s.DataCadastro);
                    break;
                case "data_cadastro_desc":
                    noticias = noticias.OrderBy(s => s.DataCadastro);
                    break;
                case "data_publicacao":
                    noticias = noticias.OrderBy(s => s.DataPublicacao);
                    break;
                case "data_publicacao_desc":
                    noticias = noticias.OrderByDescending(s => s.DataPublicacao);
                    break;
                default:
                    noticias = noticias.OrderByDescending(s => s.DataPublicacao);
                    break;
            }

            int pageSize = 3;

            var noticiaspg = await Models.PaginatedList<Noticia>.CreateAsync(noticias.AsNoTracking(), pageNumber ?? 1, pageSize);

            

            return View(noticiaspg);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var noticia = new NoticiaViewModel
            {
                DataCadastro = DateTime.Now,
                DataPublicacao = DateTime.Now
            };

            return View(noticia);
        }

        [HttpPost]
        public ActionResult Create(NoticiaViewModel noticiaViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var noticia = _mapper.Map<Noticia>(noticiaViewModel);

                    _noticiaService.Adicionar(noticia);

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Erro ao salvar notícia, " + "tente novamente.");
            }
            
            return View(noticiaViewModel);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var noticia = _mapper.Map<NoticiaViewModel>(_noticiaService.Procurar(id));

            return View(noticia);
        }

        [HttpPost]
        public ActionResult Edit(NoticiaViewModel noticiaViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var noticia = _mapper.Map<Noticia>(noticiaViewModel);

                    _noticiaService.Atualizar(noticia);

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Erro ao atualizar notícia, " + "tente novamente.");
            }
           

            return View(noticiaViewModel);
        }
    }
}
