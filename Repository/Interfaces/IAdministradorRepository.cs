using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface IAdministradorRepository
    {
        int Inserir(Administrador administrador);

        bool Atualizar(Administrador administrador);

        bool Apagar(int id);




    }
}
