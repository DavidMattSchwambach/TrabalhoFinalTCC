using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repository.DataBase
{
    internal class SistemaInitializer : CreateDatabaseIfNotExists<SistemaContext>
    {

        protected override void Seed(SistemaContext context)
        {
            #region marcas
            var marcas = new List<Marca>();
            marcas.Add(new Marca()
            {
                Id = 1,
                Nome = "Skol",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 2,
                Nome = "Proibida",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });

            context.Marcas.AddRange(marcas);
            #endregion

            #region tipos
            var tipos = new List<Tipo>();
            tipos.Add(new Tipo()
            {
                Id = 1,
                Nome = "Destilado",
                IdMarca = 1,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now


            });
            context.Tipos.AddRange(tipos);
            #endregion

            base.Seed(context);


        }



    }
}