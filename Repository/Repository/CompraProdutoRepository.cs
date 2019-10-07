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
    public class CompraProdutoRepository : ICompraProdutoRepository
    {
        SistemaContext context;

        public CompraProdutoRepository()
        {
            context = new SistemaContext();
        }

        public bool Apagar(int id)
        {
            CompraProduto compraProduto = (from x in context.ComprasProdutos where x.Id == id select x).FirstOrDefault();
            if (compraProduto == null)
            {
                return false;
            }
            compraProduto.RegistroAtivo = false;
            return context.SaveChanges() == 1;
        }

        public bool Atualizar(CompraProduto compraProduto)
        {
            CompraProduto compraProdutoOriginal = (from x in context.ComprasProdutos where x.Id == compraProduto.Id select x).FirstOrDefault();
            if (compraProdutoOriginal == null)
            {
                return false;
            }
            compraProdutoOriginal.Id = compraProduto.Id;
            compraProdutoOriginal.IdBebida = compraProduto.IdBebida;
            compraProdutoOriginal.IdAcessorio = compraProduto.IdAcessorio;

            context.SaveChanges();
            return true;
        }

        public int Inserir(CompraProduto compraProduto)
        {
            compraProduto.DataCriacao = DateTime.Now;
            compraProduto.RegistroAtivo = true;
            context.ComprasProdutos.Add(compraProduto);
            context.SaveChanges();
            return compraProduto.Id;
        }

        public CompraProduto ObterPeloIdBebida(int idBebida)
        {
            return context
                .ComprasProdutos
                .Include(x => x.Bebida.Marca)
                .Include(x => x.Acessorio)
                .Where(x => x.RegistroAtivo && x.IdBebida == idBebida)
                .FirstOrDefault();
        }

        public List<CompraProduto> ObterTodos()
        {
            return context
                .ComprasProdutos
                .Include(x => x.Bebida.Marca)
                .Include(x => x.Acessorio)
                .Where(x => x.RegistroAtivo)
                .ToList();
        }
    }
}
