using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class MarcaController : BaseController
    {
        private MarcaRepository repository;

        public MarcaController()
        {
            repository = new MarcaRepository();
        }
        // GET: Marca
        public ActionResult Index(string busca)
        {
            ViewBag.Marcas = repository.ObterTodos("");
            return View();
        }
        
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpGet, Route("cadastro")]
        public ActionResult Cadastro(Marca marca)
        {
            MarcaRepository marcaRepository = new MarcaRepository();
            ViewBag.Marcas = marcaRepository.ObterTodos();
            return View();
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
            var marca = repository.ObterPeloId(id);
            ViewBag.Marca = marca;
            return View();
        }

        [HttpPost, Route("editar")]
        public ActionResult Editar(Marca marca)
        {
            repository.Atualizar(marca);
            return RedirectToAction("Index");
        }
        public ActionResult Store(Marca marca)
        {            
            repository.Inserir(marca);
            return RedirectToAction("Index");
        }
    }
}