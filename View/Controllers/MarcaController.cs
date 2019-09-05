using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class MarcaController : Controller
    {
        private MarcaRepository repository;

        public MarcaController()
        {
            repository = new MarcaRepository();
        }
        // GET: Marca
        public ActionResult Index(string busca)
        {
            ViewBag.Marcas = repository.ObterTodos(busca);
            return View();
        }
        
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost, Route("cadastro")]
        public ActionResult Cadastro(Marca marca)
        {
            MarcaRepository marcas = new MarcaRepository();
            List<Marca> marcas1 = marcas.ObterTodos();
            ViewBag.Marca = marcas;
            return View();
        }

        [HttpGet, Route("apagar")]
        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost, Route("editar")]
        public ActionResult Editar(int id)
        {
            Marca marca = repository.ObterPeloId(id);
            ViewBag.Marca = marca;
            return View();
        }
        [HttpGet, Route("update")]
        public ActionResult Update(int id, string nome)
        {
            Marca marca = new Marca();
            marca.Id = id;
            marca.Nome = nome;
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