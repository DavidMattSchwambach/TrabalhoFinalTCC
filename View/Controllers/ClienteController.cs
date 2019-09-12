using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Interfaces;
using Repository.Repository;
using Model;

namespace View.Controllers
{

    public class ClienteController : Controller
    {
        private ClienteRepository repository;
        public ClienteController()
        {
            repository = new ClienteRepository();
        }
        // GET: Cliente
        public ActionResult Index(string busca)
        {
            List<Cliente> clientes = repository.ObterTodos(busca);
            ViewBag.Clientes = clientes;
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Cliente cliente)
        {
            repository.Inserir(cliente);
            return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Cliente cliente)
        {
            repository.Inserir(cliente);
            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Cliente cliente = repository.ObterPeloId(id);
            ViewBag.Cliente = cliente;
            return View();
        }

        public ActionResult Update(int id, string nome, DateTime dataNascimento, string cpf, string telefone,string usuario, string email, string senha)
        {
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Cpf = cpf;
            cliente.Telefone = telefone;
            cliente.Usuario = usuario;
            cliente.Email = email;
            cliente.Senha = senha;
            repository.Atualizar(cliente);
            return RedirectToAction("Index");
        }
        public ActionResult Store(Cliente cliente)
        {
            repository.Inserir(cliente);
            return RedirectToAction("Index");
        }
    }


}