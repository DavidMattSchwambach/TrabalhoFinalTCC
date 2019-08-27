using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class BebidaRepository : IBebidaRepository
    {
        public bool Alterar(Bebida bebida)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Bebida bebida)
        {
            throw new NotImplementedException();
        }

        public Bebida ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bebida> ObterTodosPeloIdTipo(int idTipo)
        {
            throw new NotImplementedException();
        }
    }
}
