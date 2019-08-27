using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface IBebidaRepository
    {
        int Inserir(Bebida bebida);

        bool Alterar(Bebida bebida);

        List<Bebida> ObterTodosPeloIdTipo(int idTipo);

        Bebida ObterPeloId(int id);

        bool Apagar(int id);
    }
}
