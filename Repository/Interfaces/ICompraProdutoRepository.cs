using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface ICompraProdutoRepository
    {

        int Inserir(CompraProduto compraProduto);

        bool Atualizar(CompraProduto compraProduto);

        bool Apagar(int id);

        List<CompraProduto> ObterTodos();

        CompraProduto ObterPeloIdBebida(int idBebida);
        CompraProduto ObterPeloId(int id);
    }
}
