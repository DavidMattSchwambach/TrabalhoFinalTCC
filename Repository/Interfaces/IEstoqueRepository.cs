using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IEstoqueRepository
    {
        int Inserir(Estoque estoque);

        bool Alterar(Estoque estoque);

        List<Estoque> ObterTodos();

        bool Apagar(int id);

        Estoque ObterPeloId(int id);
    }
}
