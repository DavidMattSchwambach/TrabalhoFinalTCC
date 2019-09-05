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
    public class AcessorioRepository : IAcessorioRepository
    {
        private SistemaContext context;
        public AcessorioRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(int id)
        {
            Acessorio acessorios = (from x in context.Acessorios where x.Id == id select x).FirstOrDefault();
            if (acessorios == null)
            {
                return false;
            }

            acessorios.RegistroAtivo = false;
            return context.SaveChanges() == 1;
        }

        public bool Alterar(Acessorio compra)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            var acessorio = context.Acessorios.FirstOrDefault(x => x.Id == id);


            if (acessorio == null)
            {
                return false;
            }

            acessorio.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();

            return quantidadeAfetada == 1;
        }

        public int Inserir(Acessorio acessorio)
        {
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
            return context.Acessorios.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
        }
 

        Compra IAcessorioRepository.ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
