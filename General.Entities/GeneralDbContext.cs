using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace General.Entities
{
   public  class GeneralDbContext:DbContext
    {
        public GeneralDbContext(DbContextOptions dbContextOptions)
        {

        }

        public DbSet<Category.Category> Categories { get; set; }
    }
}
