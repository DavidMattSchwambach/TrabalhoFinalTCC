using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class EstoqueController : Controller
    {

        private EstoqueRepository repository;
        public EstoqueController()
        {
            repository = new EstoqueRepository();
        }
        // GET: Compra
        public ActionResult Index()
        {
            List<Estoque> estoque = repository.ObterTodos();
            ViewBag.Compra = estoque;
            return View();
        }

        public ActionResult Store(int id, decimal produto)
        {
            Estoque estoque = new Estoque();
            estoque.Id = id;
            estoque.Produto = produto;
            repository.Inserir(estoque);
            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Estoque estoque= repository.ObterPeloId(id);
            ViewBag.Cliente = estoque;
            return View();
        }

        public ActionResult Update(int id, decimal produtos)
        {
            Estoque estoque = new Estoque();
            estoque.Id = id;
            estoque.Produto = produtos;
            repository.Alterar(estoque);
            return RedirectToAction("Index");
        }
    }
}