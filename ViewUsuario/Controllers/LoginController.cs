using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewUsuario.Controllers
{
    public class LoginController : Controller
    {

        private ClienteRepository repository;
        public LoginController()
        {
            repository = new ClienteRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string login, string senha)
        {
            Cliente cliente = repository.Validar(login, senha);

            if (cliente == null)
                return RedirectToAction("Index");

            Session["Cliente"] = cliente;
            return RedirectToAction("Index", "Home");
        }

    }
}