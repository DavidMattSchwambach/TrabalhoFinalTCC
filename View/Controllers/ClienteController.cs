using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Interfaces;
using Repository.Repository;
using Model;

namespace View.Controllers
{
    [Route("cliente/")]
    public class ClienteController : Controller
    {
        private IClienteRepository repository;
        public ClienteController(IClienteRepository repository)
        {
            this.repository = repository;
        }
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("cadastro")]
        public ActionResult Cadastro([FromForm]Clientes clientes)
        {
            var id = repository.Inserir(cliente);
            return RedirectToAction("Editar", new { id = id });
        }
    }


}