using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface ICartaoRepository
    {
        int Inserir(CartoesCredito cartoes);

        bool Alterar(CartoesCredito cartoes);

        List<CartoesCredito> ObterTodos();

        bool Apagar(int id);

        CartoesCredito ObterPeloId(int id);
    }
}
