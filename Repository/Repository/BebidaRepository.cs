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
    public class BebidaRepository : IBebidaRepository
    {
        private SistemaContext context;

        public BebidaRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Bebida bebida)
        {
            Bebida bebidaOriginal = (from x in context.Bebidas where x.Id == bebida.Id select x).FirstOrDefault();
            if (bebidaOriginal == null)
            {
                return false;
            }

            bebidaOriginal.Id = bebida.Id;
            bebidaOriginal.Nome = bebida.Nome;
            bebidaOriginal.Valor = bebida.Valor;
            bebidaOriginal.IdTipos = bebida.IdTipos;
            
            return context.SaveChanges() == 1;
            
        }

        public bool Apagar(int id)
        {
            var bebida = context.Bebidas.FirstOrDefault(x => x.Id == id);

            if (bebida == null)
            {
                return false;
            }

            bebida.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;
        }

        public int Inserir(Bebida bebida)
        {
            
            context.Bebidas.Add(bebida);
            context.SaveChanges();
            return bebida.Id;
        }

        public Bebida ObterPeloId(int id)
        {
            var bebida = context.Bebidas.FirstOrDefault(x => x.Id == id);
            return bebida;
        }

        public List<Bebida> ObterTodos()
        {
            return context.Bebidas.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
        }

    }
}
