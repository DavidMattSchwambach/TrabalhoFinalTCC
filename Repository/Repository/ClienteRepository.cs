using Model;
using Repository.DataBase;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        SistemaContext context;

        public ClienteRepository()
        {
            context = new SistemaContext();
        }

        public bool Apagar(int id)
        {
            Cliente cliente = (from x in context.Clientes where x.Id == id select x).FirstOrDefault();
            if (cliente == null)
            {
                return false;
            }

            cliente.RegistroAtivo = false;
            
            return context.SaveChanges() == 1;
        }

        public bool Atualizar(Cliente cliente)
        {
            Cliente clienteOriginal = (from x in context.Clientes where x.Id == cliente.Id select x).FirstOrDefault();
            if (clienteOriginal == null)
            {
                return false;
            }

            clienteOriginal.Id = cliente.Id;
            clienteOriginal.Nome = cliente.Nome;
            clienteOriginal.DataNascimento = cliente.DataNascimento;
            clienteOriginal.Telefone = cliente.Telefone;
            clienteOriginal.Usuario = cliente.Usuario;
            clienteOriginal.Cpf = cliente.Cpf;
            clienteOriginal.Email = cliente.Email;
            clienteOriginal.Senha = cliente.Senha;
            
            context.SaveChanges();
            return true;
        }

        public Cliente Validar(string login, string senha)
        {
            return context.Clientes.FirstOrDefault(x => x.Usuario == login && x.Senha == senha && x.RegistroAtivo == true);
        }

        public int Inserir(Cliente cliente)
        {
            cliente.DataCriacao = DateTime.Now;
            cliente.RegistroAtivo = true;
            context.Clientes.Add(cliente);
            context.SaveChanges();
            return cliente.Id;
        }

        public Cliente ObterPeloId(int id)
        {
            return (from x in context.Clientes where x.Id == id select x).FirstOrDefault();
        }

        public List<Cliente> ObterTodos(string busca)
        {
            //return (from x in context.Clientes where x.RegistroAtivo == true && (x.Nome.Contains(busca)) orderby x.Nome select x).ToList();
            return context.Clientes.Where(x => x.RegistroAtivo && x.Nome.Contains(busca)).ToList();
        }

        public List<Cliente> ObterTodos()
        {
            return context.Clientes.Where(x => x.RegistroAtivo).ToList();
        }
    }
}
