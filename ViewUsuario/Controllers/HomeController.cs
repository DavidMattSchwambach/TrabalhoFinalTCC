using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewUsuario.Controllers
{
    public class HomeController : BaseController
    {
        private BebidaRepository repository;
        public HomeController()
        {
            repository = new BebidaRepository();
        }
        // GET: Home
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            ViewBag.Bebidas = repository.ObterTodos();
            return View();
        }
    }
}