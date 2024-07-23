using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Hieratica.MODEL;

namespace Hieratica.DAL{
    public class HieraticaDBContext : DbContext
    {
        public HieraticaDBContext(): base()
        {

        }

        public HieraticaDBContext(DbContextOptions<HieraticaDBContext> dbContextOptions)
        : base(dbContextOptions)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Utilizador> Utilizadores { get; set;}

        public DbSet<Venda> Vendas { get; set; }

        public DbSet<Factura> Facturas { get; set; }

        //public DbSet<Encomenda> Encomendas { get; set; }

        public DbSet<Produto> Produtos {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
        
        }
    }
}


