using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class CartaoCreditoController : BaseController
    {
        private CartaoRepository repository;
        public CartaoCreditoController()
        {
            repository = new CartaoRepository();
        }

        // GET: CartaoCredito
        public ActionResult Index(string busca)
        {
            if (busca == null)
                busca = "";

            List<CartoesCredito> cartoes = repository.ObterTodos(busca);
            ViewBag.Cartoes = cartoes;
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost, Route("cadastro")]
        public ActionResult Cadastro(Cliente cliente)
        {
            CartaoRepository cartaoRepository = new CartaoRepository();
            ViewBag.Cartoes = cartaoRepository.ObterTodos();
            return View();
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
            var cartoes = repository.ObterPeloId(id);
            ViewBag.Cartoes = cartoes;
            return View();
        }

        public ActionResult Update(CartoesCredito cartoes)
        {
            repository.Alterar(cartoes);
            return RedirectToAction("Index");
        }
        public ActionResult Store(CartoesCredito cartoes)
        {
            repository.Inserir(cartoes);
            return RedirectToAction("Index");
        }

    }
}