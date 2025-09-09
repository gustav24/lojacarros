using Microsoft.EntityFrameworkCore;

namespace lojacarros.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }


        public DbSet<Carro> Carros { get; set; }
        public DbSet<CategoriaCarro> CategoriasCarros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
    }
}
