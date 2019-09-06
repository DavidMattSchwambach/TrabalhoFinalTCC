using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface ILoginClienteRepository
    {
        int Inserir(LoginCliente loginCliente);

        bool Alterar(LoginCliente loginCliente);

        List<LoginCliente> ObterTodos();

        bool Apagar(int id);

        LoginCliente ObterPeloId(int id);
    }
}
