using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewUsuario.Controllers
{

    public class CompraController : BaseController
    {
        private CompraRepository repository;

        public CompraController()
        {
            repository = new CompraRepository();
        }
        // GET: Compra
        public ActionResult Index(string busca)
        {
            List<Compra> compras = repository.ObterTodos(busca);
            ViewBag.Compra = compras;
            return View();
        }

        public ActionResult Store(Compra compra)
        {
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
            ViewBag.Compra = compra;
            return View();
        }

        public ActionResult Update(int id, decimal valor, DateTime data_compra)
        {
            Compra compra = new Compra();
            compra.Id = id;
            compra.Produto = compra.Produto;
            compra.Frete = compra.Frete;
            compra.Valor = compra.Valor;
            compra.Quantidade = compra.Quantidade;
            compra.Total = compra.Total;
            compra.DataCompra = data_compra;
            repository.Alterar(compra);
            return RedirectToAction("Index");
        }
    }
}
