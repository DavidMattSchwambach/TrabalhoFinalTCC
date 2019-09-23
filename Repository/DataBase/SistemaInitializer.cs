    using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repository.DataBase
{
    internal class SistemaInitializer : DropCreateDatabaseAlways<SistemaContext>
    //internal class SistemaInitializer : CreateDatabaseIfNotExists<SistemaContext>
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
            marcas.Add(new Marca()
            {
                Id = 3,
                Nome = "Bavaria",
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

            #region Clientes
            var cliente1 = new List<Cliente>();
            cliente1.Add(new Cliente()
            {
                Id = 1,
                Nome = "Max",
                Cpf = "086.404.459-32",
                Telefone ="(47) 999-22215",
                Email = "NunuOp@gmail.com",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now,
                DataNascimento = new DateTime(2000, 03, 20),
                Usuario = "max",
                Senha = "123"

            });
            context.Clientes.AddRange(cliente1);
            #endregion

            base.Seed(context);


        }



    }
}