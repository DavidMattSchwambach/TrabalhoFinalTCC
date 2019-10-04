using Repository.PDF;
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
        public ActionResult Index(string busca)
        {
            if (busca == null)
                busca = "";

            ViewBag.Bebidas = repository.ObterTodos(busca);
            return View();
        }

        [HttpGet, Route("info")]
        public ActionResult Info()
        {
            return View();
        }

        private RelatorioDuplicata getRelatorio()
        {
            var rpt = new RelatorioDuplicata();
            rpt.BasePath = Server.MapPath("/");

            rpt.PageTitle = "Comprovante";
            rpt.PageTitle = "Comprovante";
            rpt.ImprimirCabecalhoPadrao = true;
            rpt.ImprimirRodapePadrao = true;

            return rpt;
        }

        public ActionResult Preview()
        {
            var rpt = getRelatorio();

            return File(rpt.GetOutput().GetBuffer(), "application/pdf");
        }

        public FileResult BaixarPDF()
        {
            var rpt = getRelatorio();

            return File(rpt.GetOutput().GetBuffer(), "application/pdf", "Documento.pdf");
        }
    }
}