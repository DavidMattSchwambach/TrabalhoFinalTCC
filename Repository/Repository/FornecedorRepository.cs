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
    public class FornecedorRepository : IFornecedorRepository
    {
        SistemaContext context;

        public FornecedorRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(Fornecedor fornecedor)
        {
            Fornecedor fornecedorOriginal = (from x in context.Fornecedor where x.Id == fornecedor.Id select x).FirstOrDefault();
            if (fornecedorOriginal == null)
            {
                return false;
            }

            fornecedorOriginal.Id = fornecedor.Id;
            fornecedorOriginal.Nome = fornecedor.Nome;
            fornecedorOriginal.Preco = fornecedor.Preco;
            fornecedorOriginal.IdMarca = fornecedor.IdMarca;

            context.SaveChanges();
            return true;
        }

        public bool Apagar(int id)
        {
            Fornecedor fornecedor = (from x in context.Fornecedor where x.Id == id select x).FirstOrDefault();
            if (fornecedor == null)
            {
                return false;
            }

            fornecedor.RegistroAtivo = false;
            context.SaveChanges();
            return true;
        }

        public int Inserir(Fornecedor fornecedor)
        {
            context.Fornecedor.Add(fornecedor);
            context.SaveChanges();
            return fornecedor.Id;
        }

        public Fornecedor ObterPeloId(int id)
        {
            return (from x in context.Fornecedor where x.Id == id select x).FirstOrDefault();
        }

        public List<Fornecedor> ObterTodos()
        {
            return context.Fornecedor.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
        }

    }
}
