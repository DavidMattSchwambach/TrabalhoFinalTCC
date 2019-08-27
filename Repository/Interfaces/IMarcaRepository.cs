using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    interface IMarcaRepository
    {
        int Inserir(Marca marca);

        bool Atualizar(Marca marca);

        bool Apagar(int id);

        Marca ObterPeloId(int id);

        List<Marca> ObterTodos(string busca);
    }
}
