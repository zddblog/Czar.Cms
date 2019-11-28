using Microsoft.EntityFrameworkCore;

namespace GeneralEntities
{
    public class GeneralDbContext:DbContext
    {
        public GeneralDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
             
        }

        public DbSet<Category.Category> GetCategories { get; set; }
    }
}
