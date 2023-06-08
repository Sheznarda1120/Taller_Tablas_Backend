using Microsoft.EntityFrameworkCore;

namespace Taller_Morales_Carolina.Models
{
    public class AplicationDbContext : DbContext
    {
       public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario_1> Usuario_ { get; set; }
    }
}
