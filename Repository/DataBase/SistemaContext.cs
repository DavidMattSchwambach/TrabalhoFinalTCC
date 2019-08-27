using Model;
using System;
using System.Collections.Generic;
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

            public DbSet<Compra> Compra { get; set; }
    }
}
