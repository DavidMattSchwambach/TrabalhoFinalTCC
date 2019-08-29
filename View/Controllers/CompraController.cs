using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class CompraController : Controller
    {
        private CompraRepository repository;
        public CompraController()
        {
            repository = new CompraRepository();
        }
        // GET: Compra
        public ActionResult Index()
        {
            List<Compra> compras = repository.ObterTodos();
            ViewBag.Compra = compras;
            return View();
        }

        public ActionResult Store(int id, decimal valor,DateTime data_compra)
        {
            Compra compra = new Compra();
            compra.Id = id;
            compra.Valor = valor;
            compra.DataCompra = data_compra;
            repository.Inserir(compra);
            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Compra compra = repository.ObterPeloId(id);
            ViewBag.Cliente = compra;
            return View();
        }

        public ActionResult Update(int id, decimal valor, DateTime data_compra)
        {
            Compra compra = new Compra();
            compra.Id = id;
            compra.Valor = valor;
            compra.DataCompra = data_compra;
            repository.Alterar(compra);
            return RedirectToAction("Index");
        }
    }
}