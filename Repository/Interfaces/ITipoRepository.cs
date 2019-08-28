﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface ITipoRepository
    {
        int Inserir(Tipo tipo);

        bool Alterar(Tipo tipo);

        List<Tipo> ObterTodosPeloIdTipo(int idMarca);

        Tipo ObterPeloId(int id);

        bool Apagar(int id);
    }
}