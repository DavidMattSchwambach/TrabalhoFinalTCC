using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class FornecedorController : Controller
    {

        private FornecedorRepository repository;

        // GET: Fornecedor

            public FornecedorController()
        {
            repository = new FornecedorRepository();
        }

        public ActionResult Index()
        {
            List<Fornecedor> fornecedores = repository.ObterTodos();
            ViewBag.Fornecedores = fornecedores;
            return View();
        }

        [HttpGet, Route("cadastro")]
        public ActionResult Cadastro()
        {
            MarcaRepository marcaRepository = new MarcaRepository();
            ViewBag.Marcas = marcaRepository.ObterTodos();
            return View();
        }

        public ActionResult Store(Fornecedor fornecedor)
        {
            repository.Inserir(fornecedor);
            return RedirectToAction("Index");
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
            MarcaRepository marcaRepository = new MarcaRepository();
            var fornecedor = repository.ObterPeloId(id);
            ViewBag.Fornecedor = fornecedor;
            ViewBag.Marcas = marcaRepository.ObterTodos();
            return View();
        }

        [HttpPost, Route("update")]
        public ActionResult Update(Fornecedor fornecedor)
        {
            repository.Alterar(fornecedor);
            return RedirectToAction("Index");
        }
    }
}