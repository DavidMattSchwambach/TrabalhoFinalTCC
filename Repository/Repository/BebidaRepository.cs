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
        SistemaContext context;

        public BebidaRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Bebida bebida)
        {
            Bebida bebidaOriginal = (from x in context.Bebida where x.Id == bebida.Id select x).FirstOrDefault();
            if (bebidaOriginal == null)
            {
                return false;
            }

            bebidaOriginal.Id = bebida.Id;
            bebidaOriginal.Nome = bebida.Nome;
            bebidaOriginal.Valor = bebida.Valor;
            bebidaOriginal.IdTipo = bebida.IdTipo;
            
            context.SaveChanges();
            return true;
        }

        public bool Apagar(int id)
        {
            Bebida bebida = (from x in context.Bebida where x.Id == id select x).FirstOrDefault();
            if (bebida == null)
            {
                return false;
            }

            bebida.RegistroAtivo = false;
            context.SaveChanges();
            return true;
        }

        public int Inserir(Bebida bebida)
        {
            
            context.Bebida.Add(bebida);
            context.SaveChanges();
            return bebida.Id;
        }

        public Bebida ObterPeloId(int id)
        {
            return (from x in context.Bebida where x.Id == id select x).FirstOrDefault();
        }

        public List<Bebida> ObterTodos()
        {
            return context.Bebida.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
        }

    }
}
