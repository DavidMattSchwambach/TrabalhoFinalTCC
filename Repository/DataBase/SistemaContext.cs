using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataBase
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base("DefaultConnection")
        {
            Database.SetInitializer<SistemaContext>(new  SistemaInitializer() );
        }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<Acessorio> Acessorios { get; set; }

        public DbSet<CartoesCredito> Cartoes { get; set; }

        public DbSet<Bebida> Bebidas { get; set; }

        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Estoque> Estoques { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}
