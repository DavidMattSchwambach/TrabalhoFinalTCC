using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class BebidaController : BaseController
    {

        private BebidaRepository repository;

        // GET: Bebida

        public BebidaController()
        {
            repository = new BebidaRepository();
        }

        [HttpGet, Route("Index")]
        public ActionResult Index()
        {
            List<Bebida> bebidas = repository.ObterTodos("");
            ViewBag.Bebidas = bebidas;
            return View();
        }

        [HttpGet , Route("cadastro")]
        public ActionResult Cadastro()
        {
            MarcaRepository marcaRepository = new MarcaRepository();
            ViewBag.Marcas = marcaRepository.ObterTodos();

            TipoRepository tipoRepository = new TipoRepository();
            ViewBag.Tipos = tipoRepository.ObterTodos();

            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Bebida bebida)
        {
            repository.Inserir(bebida);
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
            var bebida = repository.ObterPeloId(id);
            ViewBag.Bebida = bebida;

            MarcaRepository marcaRepository = new MarcaRepository();
            ViewBag.Marcas = marcaRepository.ObterTodos();

            TipoRepository tipoRepository = new TipoRepository();
            ViewBag.Tipos = tipoRepository.ObterTodos();

            return View();
        }
        [HttpPost, Route("editar")]
        public ActionResult Editar(Bebida bebida)
        {

            repository.Alterar(bebida);
            return RedirectToAction("Index");
        }

        [HttpPost, Route("store")]
        public ActionResult Store(Bebida bebida)
        {
            repository.Inserir(bebida);
            return RedirectToAction("Index");
        }
    }
}