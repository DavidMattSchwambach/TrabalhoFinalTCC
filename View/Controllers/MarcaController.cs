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
        [HttpPost]
        public ActionResult Cadastro (Marca marca)
        {
            repository.Inserir(marca);
            return RedirectToAction("Index");
        }
        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id)
        {
            Marca marca = repository.ObterPeloId(id);
            ViewBag.Marca = marca;
            return View();
        }
        public ActionResult Update(int id, string nome)
        {
            Marca marca = new Marca();
            marca.Id = id;
            marca.Nome = nome;
            repository.Atualizar(marca);
            return RedirectToAction("Index");

        }
    }
}