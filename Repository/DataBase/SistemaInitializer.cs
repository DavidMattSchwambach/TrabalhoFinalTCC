using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Repository.DataBase
{
    internal class SistemaInitializer : DropCreateDatabaseAlways<SistemaContext>
    {

        protected override void Seed(SistemaContext context)
        {
            #region marcas
            var marcas = new List<Marca>();
            marcas.Add(new Marca()
            {
                Nome = "Skol",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Nome = "Proibida",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });

            context.Marcas.AddRange(marcas);
            #endregion



            base.Seed(context);
        }
    }
}