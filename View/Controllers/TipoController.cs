using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    
    public class TipoController : Controller
    {

        private TipoRepository repository;

        // GET: Tipo
        public TipoController()
        {
            repository = new TipoRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        // falta obter todos

        [HttpPost]
        public JsonResult Store(Tipo tipo)
        {
            tipo.RegistroAtivo = true;
            repository.Inserir(tipo);
            return Json(tipo);
        }

        [HttpGet]
        [Route("apagar/{id}")]
        public JsonResult Apagar(int id)
        {
            bool apagou = repository.Apagar(id);
            return Json(new { status = apagou }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet, Route("ObterPeloId/{id}")]
        public JsonResult ObterPeloId(int id)
        {
            Tipo tipo = repository.ObterPeloId(id);
            return Json(tipo, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Update(Tipo tipo)
        {
            bool alterou = repository.Alterar(tipo);
            return Json(new { status = alterou });
        }
    }
}