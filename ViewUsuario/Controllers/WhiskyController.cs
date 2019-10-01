using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewUsuario.Controllers
{
    public class WhiskyController : BaseController
    {
        // GET: Whisky
        public ActionResult Index()
        {
            return View();
        }
    }
}