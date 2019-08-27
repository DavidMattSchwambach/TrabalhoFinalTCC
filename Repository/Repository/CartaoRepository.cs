using Repository.DataBase;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CartaoRepository : ICartaoRepository
    {
        private SistemaContext context;
        public CartaoRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Model.CartoesCredito cartoes)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Model.CartoesCredito cartoes)
        {
            throw new NotImplementedException();
        }

        public Model.CartoesCredito ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Model.CartoesCredito> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
