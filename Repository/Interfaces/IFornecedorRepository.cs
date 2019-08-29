using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface IFornecedorRepository
    {
        int Inserir(Fornecedor fornecedor);

        bool Alterar(Fornecedor fornecedor);

        List<Fornecedor> ObterTodos();

        Fornecedor ObterPeloId(int id);

        bool Apagar(int id);
    }
}
