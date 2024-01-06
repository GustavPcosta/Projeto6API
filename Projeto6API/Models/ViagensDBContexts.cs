using Microsoft.EntityFrameworkCore;

namespace Projeto6API.Models
{
    public class ViagensDBContexts : DbContext
    {


        public ViagensDBContexts(DbContextOptions<ViagensDBContexts> options) 
            : base(options) { }
        public DbSet<Destino> Destino { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
