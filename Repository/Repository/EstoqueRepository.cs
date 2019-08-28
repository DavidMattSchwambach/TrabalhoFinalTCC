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
    public class EstoqueRepository : IEstoqueRepository
    {
        private SistemaContext context;
        public EstoqueRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Estoque estoque)
        {
            Estoque estoques = (from x in context.Estoques where x.Id == estoque.Id select x).FirstOrDefault();
            if (estoques == null)
            {
                return false;
            }

            estoques.Produto = estoque.Produto;
            

            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Estoque estoque)
        {
            throw new NotImplementedException();
        }

        public Estoque ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estoque> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
