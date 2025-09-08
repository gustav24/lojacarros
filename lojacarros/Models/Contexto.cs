using Microsoft.EntityFrameworkCore;

namespace lojacarros.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

       
        public DbSet<Carro> Carros { get; set; }
    }
}
