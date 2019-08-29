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
            Fornecedor fornecedorOriginal = (from x in context.Fornecedores where x.Id == fornecedor.Id select x).FirstOrDefault();
            if (fornecedorOriginal == null)
            {
                return false;
            }

            fornecedorOriginal.Id = fornecedor.Id;
            fornecedorOriginal.Nome = fornecedor.Nome;
            fornecedorOriginal.Preco = fornecedor.Preco;
            fornecedorOriginal.IdMarcas = fornecedor.IdMarcas;

            return context.SaveChanges() == 1;
            
        }

        public bool Apagar(int id)
        {
            var fornecedor = context.Fornecedores.FirstOrDefault(x => x.Id == id);
            if (fornecedor == null)
            {
                return false;
            }

            fornecedor.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;
        }

        public int Inserir(Fornecedor fornecedor)
        {
            context.Fornecedores.Add(fornecedor);
            context.SaveChanges();
            return fornecedor.Id;
        }

        public Fornecedor ObterPeloId(int id)
        {
            var fornecedor = context.Fornecedores.FirstOrDefault(x => x.Id == id);
            return fornecedor;
        }

        public List<Fornecedor> ObterTodos()
        {
            return context.Fornecedores.Where(x => x.RegistroAtivo == true).OrderBy(x => x.Id).ToList();
        }

    }
}
