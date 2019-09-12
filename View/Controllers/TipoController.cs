using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    
    public class TipoController : Controller
    {

        private TipoRepository repository;

        // GET: Tipo
        public TipoController()
        {
            repository = new TipoRepository();
        }

        [HttpGet, Route("Index")]
        public ActionResult Index()
        {
            List<Tipo> tipos = repository.ObterTodos();
            ViewBag.Tipos = tipos;
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            MarcaRepository marcaRepository = new MarcaRepository();
            ViewBag.Marcas = marcaRepository.ObterTodos();


            //TipoRepository tipoRepository = new TipoRepository();
            //List<Tipo> tipos = tipoRepository.ObterTodos();
            // ViewBag.Tipos = tipos;
            return View();
        }

        public ActionResult Store(Tipo tipo)
        {
            repository.Inserir(tipo);
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
            var tipo = repository.ObterPeloId(id);
            ViewBag.Tipo = tipo;

            MarcaRepository marcaRepository = new MarcaRepository();
            ViewBag.Marcas = marcaRepository.ObterTodos();

            return View();
        }

        [HttpPost, Route("editar")]
        public ActionResult Editar(Tipo tipo)
        {
            var alterado = repository.Alterar(tipo);
            return RedirectToAction("Index");
        }
    }
}