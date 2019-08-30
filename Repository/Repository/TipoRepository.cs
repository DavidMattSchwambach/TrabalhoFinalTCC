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
            Tipo tipo = (from x in context.Tipos where x.Id == id select x).FirstOrDefault();
            if (tipo == null)
            {
                return false;
            }

            
            tipo.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();

            return quantidadeAfetada == 1; ;
        }

        public int Inserir(Tipo tipo)
        {
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
            return null;
        }

        public List<Tipo> ObterTodos(string busca)
        {
            return (from x in context.Tipos where x.RegistroAtivo == true && (x.Nome.Contains(busca)) orderby x.Nome select x).ToList();
        }
    }
}
