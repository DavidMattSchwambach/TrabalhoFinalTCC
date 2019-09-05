using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
            

            #region tipos
            var tipos = new List<Tipo>();
            tipos.Add(new Tipo()
            {
                Nome = "Destilado",
                Marca = context.Marcas
                .Where(x => x.Nome == "Proibida")
                .FirstOrDefault(),
                RegistroAtivo = true,
                DataCriacao = DateTime.Now

                 
        });
             context.Tipos.AddRange(tipos);
            #endregion

            base.Seed(context);

            
        }



    }
}