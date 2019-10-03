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
        private CompraProdutoRepository compraProdutoRepository;

        public CompraController()
        {
            repository = new CompraRepository();
            compraProdutoRepository = new CompraProdutoRepository();
        }
        // GET: Compra
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            List<CompraProduto> compras = compraProdutoRepository.ObterTodos();
            foreach (var compra in compras)
            {
                if (compra.Bebida != null)
                    compra.ValorTotal = compra.Quantidade * compra.Bebida.Valor;
                else if (compra.Acessorio != null)
                    compra.ValorTotal = compra.Quantidade * compra.Acessorio.Preco;
            }
            ViewBag.Compras = compras;
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
            compra.Total = compra.Total;
            compra.DataCompra = data_compra;
            repository.Alterar(compra);
            return RedirectToAction("Index");
            
        }
    }
}
