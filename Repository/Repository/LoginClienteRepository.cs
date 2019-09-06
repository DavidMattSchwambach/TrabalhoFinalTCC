using Model;
using Repository.DataBase;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class LoginClienteRepository : ILoginClienteRepository
    {
        private SistemaContext context;

        public LoginClienteRepository()
        {
            context = new SistemaContext();
        }
        public bool Alterar(LoginCliente loginCliente)
        {
            LoginCliente loginClienteOriginal = (from x in context.LoginClientes where x.Id == loginCliente.Id select x).FirstOrDefault();
            if (loginClienteOriginal == null)
            {
                return false;
            }

            loginClienteOriginal.Id = loginCliente.Id;
            loginClienteOriginal.usuario = loginCliente.usuario;
            loginClienteOriginal.senha = loginCliente.senha;
            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            var logincliente = context.LoginClientes.FirstOrDefault(x => x.Id == id);

            if (logincliente == null)
            {
                return false;
            }

            logincliente.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;
        }

        public int Inserir(LoginCliente loginCliente)
        {
            loginCliente.DataCriacao = DateTime.Now;
            context.LoginClientes.Add(loginCliente);
            context.SaveChanges();
            return loginCliente.Id;
        }

        public LoginCliente ObterPeloId(int id)
        {
            return (from x in context.LoginClientes where x.Id == id select x).FirstOrDefault();
        }

        public List<LoginCliente> ObterTodos()
        {
            return context.LoginClientes.ToList();
        }
    }
}
