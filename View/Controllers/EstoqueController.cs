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
            ViewBag.Estoques = estoque;
            return View();
        }

        public ActionResult Store(Estoque estoque)
        {
            repository.Inserir(estoque);
            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult ObterPeloId(int id)
        {
            Estoque estoque = repository.ObterPeloId(id);
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

        public ActionResult Editar(int id)
        {
            Estoque estoque = repository.ObterPeloId(id);
            ViewBag.Estoque = estoque;
            return View();
        }

        public ActionResult Cadastro()
        {
            EstoqueRepository estoque = new EstoqueRepository();
            List<Estoque> estoques = estoque.ObterTodos();
            ViewBag.Estoque = estoque;
            return View();
        }
    }
}