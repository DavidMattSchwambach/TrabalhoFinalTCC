using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewUsuario.Controllers
{
    public class CervejaController : BaseController
    {
        // GET: Cerveja
        public ActionResult Index()
        {
            return View();
        }
    }
}