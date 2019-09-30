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
    public class CompraRepository : ICompraRepository
    {

        private SistemaContext context;
        public CompraRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Compra compra)
        {
            Compra compra1 = (from x in context.Compras where x.Id == compra.Id select x).FirstOrDefault();
            if (compra1 == null)
            {
                return false;
            }

            compra1.Id = compra.Id;
            compra1.Frete = compra.Frete;
            compra1.Total = compra.Total;
            compra1.DataCompra = compra.DataCompra;
            compra1.IdCartaoCredito = compra.IdCartaoCredito;
           

            return context.SaveChanges() == 1;
        }

        public Compra ObterCompraPeloIdCliente(int id)
        {
            return context.Compras.FirstOrDefault(x => x.IdCliente == id);
        }

        public bool Apagar(int id)
        {
            var compra = context.Compras.FirstOrDefault(x => x.Id == id);


            if (compra == null)
            {
                return false;
            }

            compra.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();

            return quantidadeAfetada == 1;
        }

        public int Inserir(Compra compra)
        {
            compra.RegistroAtivo = true;
            compra.DataCriacao = DateTime.Now;
            context.Compras.Add(compra);
            context.SaveChanges();
            return compra.Id;
        }

        public Compra ObterPeloId(int id)
        {
            var compra = context.Compras.FirstOrDefault(x => x.Id == id);
            return compra;
        }

        public List<Compra> ObterTodos(string busca)
        {
            return context.Compras.Where(x => x.RegistroAtivo).OrderBy(x => x.Id).ToList();
        }
    }
}
