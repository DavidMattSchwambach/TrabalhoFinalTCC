using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface IAcessorioRepository
    {
        int Inserir(Acessorio compra);

        bool Alterar(Acessorio compra);

        List<Acessorio> ObterTodos();

        bool Apagar(int id);

        Compra ObterPeloId(int id);
    }
}
