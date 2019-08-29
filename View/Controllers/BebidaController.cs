using Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class BebidaController : Controller
    {

        private BebidaRepository repository;

        // GET: Bebida

        public BebidaController()
        {
            repository = new BebidaRepository();
        }

        public ActionResult Index()
        {
            List<Bebida> bebidas = repository.ObterTodos();
            ViewBag.Bebidas = bebidas;
            return View();
        }

        public ActionResult Cadastro()
        {
            BebidaRepository bebidaRepository = new BebidaRepository();
            List<Bebida> bebidas = bebidaRepository.ObterTodos();
            ViewBag.Bebidas = bebidas;
            return View();
        }

        public ActionResult Store(int idTipo, string nome, decimal valor)
        {
            Bebida bebida = new Bebida();
            bebida.IdTipo = idTipo;
            bebida.Nome = nome;
            bebida.Valor = valor;
            repository.Inserir(bebida);
            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Bebida bebida = repository.ObterPeloId(id);
            ViewBag.Bebida = bebida;

            BebidaRepository bebidaRepository = new BebidaRepository();
            List<Bebida> bebidas = bebidaRepository.ObterTodos();
            ViewBag.Bebidas = bebidas;
            return View();
        }

        
    }
}