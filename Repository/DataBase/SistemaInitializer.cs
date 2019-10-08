using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repository.DataBase
{
    //internal class SistemaInitializer : DropCreateDatabaseAlways<SistemaContext>
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
                Nome = "Kaiser",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 3,
                Nome = "Heineken",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 4,
                Nome = "Jack Daniels",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 5,
                Nome = "Johnnie Walker",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 6,
                Nome = "Famous Grouse",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });

            // REFRIGERANTES*/
            marcas.Add(new Marca()
            {
                Id = 7,
                Nome = "Coca-Cola",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 8,
                Nome = "Pepsi",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 9,
                Nome = "Guarana",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            // SUCOS*/
            marcas.Add(new Marca()
            {
                Id = 10,
                Nome = "Dell Vale",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 11,
                Nome = "Maguary",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 12,
                Nome = "Prats",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            // Vodka */
            marcas.Add(new Marca()
            {
                Id = 13,
                Nome = "Absolut",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 14,
                Nome = "Skyy",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 15,
                Nome = "Smirnoff",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 16,
                Nome = "Crystal",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 17,
                Nome = "Voss",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            marcas.Add(new Marca()
            {
                Id = 18,
                Nome = "Leve",
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
                Nome = "Fermentado",
                IdMarca = 1,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 2,
                Nome = "Fermentado",
                IdMarca = 2,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 3,
                Nome = "Fermentado",
                IdMarca = 3,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 4,
                Nome = "Destilado",
                IdMarca = 4,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 5,
                Nome = "Destilado",
                IdMarca = 5,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 6,
                Nome = "Destilado",
                IdMarca = 6,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 7,
                Nome = "Refrigerante",
                IdMarca = 7,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 8,
                Nome = "Refrigerante",
                IdMarca = 8,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 9,
                Nome = "Refrigerante",
                IdMarca = 9,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 10,
                Nome = "Suco",
                IdMarca = 10,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 11,
                Nome = "Suco",
                IdMarca = 11,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 12,
                Nome = "Suco",
                IdMarca = 12,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 13,
                Nome = "Vodka",
                IdMarca = 13,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 14,
                Nome = "Vodka",
                IdMarca = 14,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 15,
                Nome = "Vodka",
                IdMarca = 15,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 16,
                Nome = "Água",
                IdMarca = 16,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 17,
                Nome = "Água",
                IdMarca = 17,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 18,
                Nome = "Água",
                IdMarca = 18,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });


            // TIPOS PARA ACESSÓRIOS */
            tipos.Add(new Tipo()
            {
                Id = 19,
                Nome = "Taça de Água",
                IdMarca = 2,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 20,
                Nome = "Bolacha de Bebida",
                IdMarca = 2,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new Tipo()
            {
                Id = 21,

                Nome = "Abridor de Garrafa",
                IdMarca = 2,
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
                Telefone = "(47) 999-22215",
                Email = "NunuOp@gmail.com",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now,
                DataNascimento = new DateTime(2000, 03, 20),
                Usuario = "max",
                Senha = "123"

            });
            cliente1.Add(new Cliente()
            {
                Id = 2,
                Nome = "Breno",
                Cpf = "086.404.459-32",
                Telefone = "(47) 999-23456",
                Email = "Joao34@gmail.com",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now,
                DataNascimento = new DateTime(2001, 05, 20),
                Usuario = "Breno",
                Senha = "123"

            });
            cliente1.Add(new Cliente()
            {
                Id = 3,
                Nome = "David",
                Cpf = "086.424.469-32",
                Telefone = "(47) 999-32456",
                Email = "Joao34@gmail.com",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now,
                DataNascimento = new DateTime(2001, 06, 21),
                Usuario = "David",
                Senha = "123"

            });
            cliente1.Add(new Cliente()
            {
                Id = 4,
                Nome = "Evelyn",
                Cpf = "086.324.479-42",
                Telefone = "(47) 969-32666",
                Email = "Joao34@gmail.com",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now,
                DataNascimento = new DateTime(1999, 06, 21),
                Usuario = "evelyn",
                Senha = "123"

            });
            cliente1.Add(new Cliente()
            {
                Id = 5,
                Nome = "Jotaro",
                Cpf = "247.368.459-32",
                Telefone = "(47) 988-23265",
                Email = "Jotarokujo@gmail.com",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now,
                DataNascimento = new DateTime(2000, 03, 20),
                Usuario = "Jotaro",
                Senha = "kujo"

            });
            cliente1.Add(new Cliente()
            {
                Id = 6,
                Nome = "Lucas",
                Cpf = "247.368.459-32",
                Telefone = "(47) 988-23265",
                Email = "lucas@gmail.com",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now,
                DataNascimento = new DateTime(2000, 04, 20),
                Usuario = "Lucas",
                Senha = "123"

            });
            context.Clientes.AddRange(cliente1);
            #endregion
            #region Bebidas
            var bebida1 = new List<Bebida>();
            bebida1.Add(new Bebida()
            {
                Id = 1,
                Nome = "Cerveja",
                Valor = 3,
                IdMarca = 2,
                IdTipo = 2,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 2,
                Nome = "Cerveja",
                Valor = 4,
                IdMarca = 1,
                IdTipo = 1,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 3,
                Nome = "Cerveja",
                Valor = 5,
                IdMarca = 3,
                IdTipo = 3,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 4,
                Nome = "Whisky",
                Valor = 75,
                IdMarca = 4,
                IdTipo = 4,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 5,
                Nome = "Whisky",
                Valor = 119,
                IdMarca = 5,
                IdTipo = 5,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 6,
                Nome = "Whisky",
                Valor = 119,
                IdMarca = 6,
                IdTipo = 6,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 7,
                Nome = "Refrigerante",
                Valor = 3,
                IdMarca = 7,
                IdTipo = 7,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 8,
                Nome = "Refrigerante",
                Valor = 4,
                IdMarca = 8,
                IdTipo = 8,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 9,
                Nome = "Refrigerante",
                Valor = 3,
                IdMarca = 9,
                IdTipo = 9,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 10,
                Nome = "Suco",
                Valor = 13,
                IdMarca = 10,
                IdTipo = 10,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 11,
                Nome = "Suco",
                Valor = 13,
                IdMarca = 11,
                IdTipo = 11,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 12,
                Nome = "Suco",
                Valor = 13,
                IdMarca = 12,
                IdTipo = 12,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 13,
                Nome = "Vodka",
                Valor = 72,
                IdMarca = 13,
                IdTipo = 13,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 14,
                Nome = "Vodka",
                Valor = 54,
                IdMarca = 14,
                IdTipo = 14,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 15,
                Nome = "Vodka",
                Valor = 89,
                IdMarca = 15,
                IdTipo = 15,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 16,
                Nome = "Água",
                Valor = 10,
                IdMarca = 16,
                IdTipo = 16,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 17,
                Nome = "Água",
                Valor = 15,
                IdMarca = 17,
                IdTipo = 17,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            bebida1.Add(new Bebida()
            {
                Id = 18,
                Nome = "Água",
                Valor = 9,
                IdMarca = 18,
                IdTipo = 18,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            context.Bebidas.AddRange(bebida1);
            #endregion
            #region Acessório
            var acessorio1 = new List<Acessorio>();
            acessorio1.Add(new Acessorio()
            {
                Id = 1,
                Nome = "Taça",
                Preco = 9,
                IdTipo = 19,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            acessorio1.Add(new Acessorio()
            {
                Id = 2,
                Nome = "Bolacha para bebidas",
                Preco = 9,
                IdTipo = 20,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            acessorio1.Add(new Acessorio()
            {
                Id = 3,
                Nome = "Abridor de garrafa",
                Preco = 20,
                IdTipo = 21,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            context.Acessorios.AddRange(acessorio1);

            #endregion
            #region Fornecedor
            var fornecedor = new List<Fornecedor>();
            fornecedor.Add(new Fornecedor()
            {
                Id = 1,
                Nome = "Ambev",
                Preco = 350,
                IdMarca = 3,
                Quantidade = 300,
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });
            context.Fornecedores.AddRange(fornecedor);

            #endregion

            #region Administrador
            var administrador = new List<Administrador>();
            administrador.Add(new Administrador()
            {
                Id = 1,
                Usuario = "Jotaro",
                Senha = "123",
                RegistroAtivo = true,
                DataCriacao = DateTime.Now
            });

            context.Administradores.AddRange(administrador);
            #endregion

            base.Seed(context);
        }

    }

}

