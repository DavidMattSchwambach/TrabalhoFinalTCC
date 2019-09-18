using Model;
using Repository.DataBase;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class AcessorioRepository : IAcessorioRepository
    {
        private SistemaContext context;
        public AcessorioRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Acessorio acessorio)
        {
            Acessorio acessoriosOriginal = (from x in context.Acessorios where x.Id == acessorio.Id select x).FirstOrDefault();
            if (acessoriosOriginal == null)
            {
                return false;
            }
            acessoriosOriginal.Id = acessorio.Id;
            acessoriosOriginal.Nome = acessorio.Nome;
            acessoriosOriginal.Preco = acessorio.Preco;
            acessoriosOriginal.IdTipo = acessorio.IdTipo;

            context.SaveChanges();
            return true;
        }


        public bool Apagar(int id)
        {
            var acessorio = context.Acessorios.FirstOrDefault(x => x.Id == id);
            if (acessorio == null)
            {
                return false;
            }

            acessorio.RegistroAtivo = false;
            return context.SaveChanges() == 1;
        }

        public int Inserir(Acessorio acessorio)
        {
            acessorio.RegistroAtivo = true;
            acessorio.DataCriacao = DateTime.Now;
            context.Acessorios.Add(acessorio);
            context.SaveChanges();
            return acessorio.Id;
        }

        public Acessorio ObterPeloId(int id)
        {
            var acessorio = context.Acessorios.FirstOrDefault(x => x.Id == id);
            return acessorio;
        }

        public List<Acessorio> ObterTodos()
        {
            return context.Acessorios
               .Where(x => x.RegistroAtivo)
               .Include(x => x.Tipo)
               .ToList();
        }
       


    }
}
