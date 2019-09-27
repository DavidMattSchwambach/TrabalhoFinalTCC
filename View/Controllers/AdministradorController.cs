using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class AdministradorController : BaseController
    {
        private AdministradorRepository repository;

        public AdministradorController()
        {
            repository = new AdministradorRepository();
        }

        [HttpGet, Route("Index")]
        public ActionResult Index()
        {
            List<Administrador> administradores = repository.ObterTodos();
            ViewBag.Administradores = administradores;
            return View();
        }
        public ActionResult Cadastro()
        {
            AdministradorRepository administrador = new AdministradorRepository();
            ViewBag.Administradores = administrador.ObterTodos();
            return View();
        }
        [HttpPost]
        public ActionResult Login(string login, string senha)
        {
            Administrador administrador = repository.Validar(login, senha);

            if (administrador == null)
                return RedirectToAction("Index");

            Session["Administrador"] = administrador;
            return RedirectToAction("Index", "Home");
        }

    }
}