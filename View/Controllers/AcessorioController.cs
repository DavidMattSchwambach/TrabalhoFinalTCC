using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class AcessorioController : BaseController
    {

        private AcessorioRepository repository;

        // GET: Acessorio
        public AcessorioController()
        {
            repository = new AcessorioRepository();
        }

        [HttpGet, Route("Index")]
        public ActionResult Index()
        {
            List<Acessorio> acessorios = repository.ObterTodos();
            ViewBag.Acessorios = acessorios;
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            TipoRepository tipoRepository = new TipoRepository();
            ViewBag.Tipos = tipoRepository.ObterTodos();
            return View();
        }

        [HttpPost, Route("store")]
        public ActionResult Store(Acessorio acessorio)
        {
            repository.Inserir(acessorio);
            return RedirectToAction("Index");
        }

        [HttpGet, Route("apagar")]
        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpGet, Route("editar")]
        public ActionResult Editar(int id)
        {
            var acessorio = repository.ObterPeloId(id);
            ViewBag.Acessorio = acessorio;

            TipoRepository tipoRepository = new TipoRepository();
            ViewBag.Tipos = tipoRepository.ObterTodos();

            return View();
        }

        [HttpPost, Route("editar")]
        public ActionResult Editar(Acessorio acessorio)
        {
            repository.Alterar(acessorio);
            return RedirectToAction("Index");
        }
    }
}