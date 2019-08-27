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
    public class CartaoRepository : ICartaoRepository
    {
        private SistemaContext context;
        public CartaoRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(CartoesCredito cartoes)
        {
            var cartao = context.Cartoes.FirstOrDefault(x => x.Id == cartoes.Id);

            if (cartao == null)
                return false;

            cartao.Numero = cartoes.Numero;
            cartao.DataVencimento = cartoes.DataVencimento;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            var cartao = context.Cartoes.FirstOrDefault(x => x.Id == id);


            if (cartao == null)
            {
                return false;
            }

            cartao.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();

            return quantidadeAfetada == 1;
        }

        public int Inserir(CartoesCredito cartoes)
        {
            cartoes.DataCriacao = DateTime.Now;
            context.Cartoes.Add(cartoes);
            context.SaveChanges();
            return cartoes.Id;
        }

        public CartoesCredito ObterPeloId(int id)
        {
            return (from x in context.Cartoes where x.Id == id select x).FirstOrDefault();
        }

        public List<CartoesCredito> ObterTodos(string busca)
        {
            return (from x in context.Cartoes where x.RegistroAtivo == true && (x.Numero.Contains(busca)) orderby x.Numero select x).ToList();
        }

        public List<CartoesCredito> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
