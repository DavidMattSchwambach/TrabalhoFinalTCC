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
    public class TipoRepository : ITipoRepository
    {
        SistemaContext context;

        public TipoRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Tipo tipo)
        {
            Tipo tipoOriginal = (from x in context.Tipo where x.Id == tipo.Id select x).FirstOrDefault();
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
            Tipo tipo = (from x in context.Tipo where x.Id == id select x).FirstOrDefault();
            if (tipo == null)
            {
                return false;
            }

            tipo.RegistroAtivo = false;
            context.SaveChanges();
            return true;
        }

        public int Inserir(Tipo tipo)
        {
            context.Tipo.Add(tipo);
            context.SaveChanges();
            return tipo.Id;
        }

        public Tipo ObterPeloId(int id)
        {
            return (from x in context.Tipo where x.Id == id select x).FirstOrDefault();
        }

        public List<Tipo> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
