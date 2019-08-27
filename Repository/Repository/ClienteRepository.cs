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
        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos(string busca)
        {
            throw new NotImplementedException();
        }
    }
}
