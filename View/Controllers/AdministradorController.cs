﻿using Model;
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
            List<Administrador> administradors = repository.ObterTodos();
            ViewBag.Administradores = administradors;
            return View();
        }
        public ActionResult Cadastro()
        {
            AdministradorRepository administrador = new AdministradorRepository();
            ViewBag.Administrador = administrador.ObterTodos();
            return View();
        }

    }
}