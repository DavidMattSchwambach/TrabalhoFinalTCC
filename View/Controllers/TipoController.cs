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

        public ActionResult Index()
        {
            List<Tipo> tipos = repository.ObterTodos();
            ViewBag.Tipos = tipos;
            return View();
        }

        public ActionResult Cadastro()
        {
            TipoRepository tipoRepository = new TipoRepository();
            List<Tipo> tipos = tipoRepository.ObterTodos();
            ViewBag.Tipos = tipos;
            return View();

        }

        public ActionResult Store(int idMarca, string nome)
        {
            Tipo tipo = new Tipo();
            tipo.IdMarcas = idMarca;
            tipo.Nome = nome;
            repository.Inserir(tipo);
            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Tipo tipo = repository.ObterPeloId(id);
            ViewBag.Tipo = tipo;

            TipoRepository tipoRepository = new TipoRepository();
            List<Tipo> tipos = tipoRepository.ObterTodos();
            ViewBag.Tipos = tipos;
            return View();
        }

        public ActionResult Update(int id, string nome, int idMarca)
        {
            Tipo tipo = new Tipo();
            tipo.Id = id;
            tipo.Nome = nome;
            tipo.IdMarcas = idMarca;
            repository.Alterar(tipo);

            return RedirectToAction("Index");
        }
    }
}