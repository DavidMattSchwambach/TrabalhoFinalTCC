using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewUsuario.Controllers
{
    public class CompraProdutoController : BaseController
    {
        private CompraProdutoRepository repository;
        private CompraRepository repositoryCompra;

        public CompraProdutoController()
        {
            repository = new CompraProdutoRepository();
            repositoryCompra = new CompraRepository();
        }
        // GET: CompraProduto
        public ActionResult Index()
        {
            List<CompraProduto> comprasProduto = repository.ObterTodos();
            ViewBag.CompraProduto = comprasProduto;
            return View();
        }

        public ActionResult Store(int IdBebida)
        {

            var cliente = (Cliente)Session["Cliente"];
            var compra = repositoryCompra.ObterCompraPeloIdCliente(cliente.Id);

            if (compra == null)
            {
                compra = new Compra()
                {
                    IdCliente = cliente.Id,
                    RegistroAtivo = true,
                    Total = 0,
                    DataCriacao = DateTime.Now,
                    DataCompra = DateTime.Now,

                };
                repositoryCompra.Inserir(compra);
            }

            var compraProduto = new CompraProduto()
            {
                IdBebida = IdBebida,
                IdCompra = compra.Id,
                DataCriacao = DateTime.Now,
                RegistroAtivo = true,
                Quantidade = 1
            };

            repository.Inserir(compraProduto);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost,Route("apagar")]
        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}