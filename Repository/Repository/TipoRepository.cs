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
    public class TipoRepository : ITipoRepository
    {
        private SistemaContext context;
        public TipoRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Tipo tipo)
        {
            Tipo tipoOriginal = (from x in context.Tipos where x.Id == tipo.Id select x).FirstOrDefault();
            if (tipoOriginal == null)
            {
                return false;
            }

            tipoOriginal.Id = tipo.Id;
            tipoOriginal.Nome = tipo.Nome;
            tipoOriginal.IdMarca = tipo.IdMarca;

            context.SaveChanges();
            return true;
        }

        public bool Apagar(int id)
        {
            var tipo = context.Tipos.FirstOrDefault(x => x.Id == id);
            if (tipo == null)
                return false;

            tipo.RegistroAtivo = false;
            return context.SaveChanges() == 1;
        }

        public int Inserir(Tipo tipo)
        {
            tipo.RegistroAtivo = true;
            tipo.DataCriacao = DateTime.Now;
            context.Tipos.Add(tipo);
            context.SaveChanges();
            return tipo.Id;
        }

        public Tipo ObterPeloId(int id)
        {
            var tipo = context.Tipos.FirstOrDefault(x => x.Id == id);
            return tipo;
        }

        public List<Tipo> ObterTodos()
        {
            return context.Tipos
                .Where(x => x.RegistroAtivo)
                .Include(x => x.Marca)
                .ToList();
        }

        public List<Tipo> ObterTodos(string busca)
        {
            return context.Tipos.Where(x => x.RegistroAtivo && x.Nome.Contains(busca) || x.Marca.Nome.Contains(busca)).ToList();
        }
    }
}
