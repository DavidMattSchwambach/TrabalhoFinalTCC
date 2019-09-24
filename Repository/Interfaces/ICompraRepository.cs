using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ICompraRepository
    {
        int Inserir(Compra compra);

        bool Alterar(Compra compra);

        List<Compra> ObterTodos(string busca);

        bool Apagar(int id);

        Compra ObterPeloId(int id);
    }
}
