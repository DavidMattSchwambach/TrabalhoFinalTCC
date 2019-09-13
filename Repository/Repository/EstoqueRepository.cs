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
            estoque.DataCriacao = DateTime.Now;
            estoque.RegistroAtivo = true;
            context.Estoques.Add(estoque);
            context.SaveChanges();
            return estoque.Id;
        }

        public Estoque ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estoque> ObterTodos(int id)
        {
            return context.Estoques.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
        }

        public List<Estoque> ObterTodos()
        {
            return context.Estoques.ToList();
        }
    }
}
