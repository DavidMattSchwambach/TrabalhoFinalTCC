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
            var compraA = context.Compra.FirstOrDefault(x => x.Id == compra.Id);

            if (compraA == null)
                return false;

            compraA.Valor = compra.Valor;
            compraA.DataCompra = compra.DataCompra;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            var compra = context.Compra.FirstOrDefault(x => x.Id == id);


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
            context.Compra.Add(compra);
            context.SaveChanges();
            return compra.Id;
        }

        public Compra ObterPeloId(int id)
        {
            var compra = context.Compra.FirstOrDefault(x => x.Id == id);
            return compra;
        }

        public List<Compra> ObterTodos()
        {
            return context.Compra.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
        }
    }
}
