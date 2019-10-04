using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Interfaces;
using Repository.Repository;
using Model;


namespace ViewUsuario.Controllers
{
    public class ClienteController : BaseController
    {
        private ClienteRepository repository;
        public ClienteController()
        {
            repository = new ClienteRepository();
        }
        // GET: Cliente
        public ActionResult Index(string busca)
        {
            if (busca == null)
                busca = "";

            List<Cliente> clientes = repository.ObterTodos(busca);
            ViewBag.Clientes = clientes;
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
            var cliente = repository.ObterPeloId(id);
            ViewBag.Cliente = cliente;
            return View();
        }

        public ActionResult Update(Cliente cliente)
        {
            repository.Atualizar(cliente);
            return RedirectToAction("Index");
        }
        public ActionResult Store(Cliente cliente)
        {
            repository.Inserir(cliente);
            return RedirectToAction("Index");
        }
    }
}