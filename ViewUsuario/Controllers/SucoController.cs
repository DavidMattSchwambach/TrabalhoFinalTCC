using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewUsuario.Controllers
{
    public class SucoController : BaseController
    {
        // GET: Suco
        public ActionResult Index()
        {
            return View();
        }
    }
}