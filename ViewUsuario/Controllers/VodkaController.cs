using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewUsuario.Controllers
{
    public class VodkaController : BaseController
    {
        // GET: Vodka
        public ActionResult Index()
        {
            return View();
        }
    }
}