using Microsoft.EntityFrameworkCore;

namespace General.Entities
{
    public class GeneralDbContext : DbContext
    {
        public GeneralDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category.Category> Categories { get; set; }
    }
}
