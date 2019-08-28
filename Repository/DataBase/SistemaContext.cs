using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataBase
{
    public class SistemaContext : DbContext
    {
            public SistemaContext() : base("DefaultConnection")
            {
            }
            public DbSet<Cliente> Clientes { get; set; }

            public DbSet<Marca> Marcas { get; set; }

            public DbSet<Compra> Compras { get; set; }

            public DbSet<Acessorio> Acessorios { get; set; }

            public DbSet<CartoesCredito> Cartoes { get; set; }

            public DbSet<Bebida> Bebida { get; set; }

            public DbSet<Tipo> Tipo { get; set; }
            public DbSet<Fornecedor> Fornecedor { get; set; }

            public DbSet<Estoque> Estoques { get; set; }


    }
}
