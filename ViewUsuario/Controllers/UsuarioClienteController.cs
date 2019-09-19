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
    public class UsuarioClienteController : Controller
    {
        private ClienteRepository repository;
        public UsuarioClienteController()
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

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost, Route("cadastro")]
        public ActionResult Cadastro(Cliente cliente)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            ViewBag.Clientes = clienteRepository.ObterTodos();
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Cliente cliente)
        {
            repository.Inserir(cliente);
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