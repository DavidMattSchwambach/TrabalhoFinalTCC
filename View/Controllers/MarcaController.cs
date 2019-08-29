using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class MarcaController : Controller
    {
        private MarcaRepository repository;

        public MarcaController()
        {
            repository = new MarcaRepository();
        }
        // GET: Marca
        public ActionResult Index(string busca)
        {
            ViewBag.Marcas = repository.ObterTodos(busca);
            return View();
        }

       
    }
}