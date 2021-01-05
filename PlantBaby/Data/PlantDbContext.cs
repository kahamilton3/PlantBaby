using PlantBaby.Models;
using Microsoft.EntityFrameworkCore;

namespace PlantBaby.Data
{
    public class PlantDbContext : DbContext
    {
        public DbSet<MyPlantBaby> MyPlantBabies { get; set; }
        public DbSet<PlantParent> PlantParents { get; set; }
        public DbSet<PlantType> PlantTypes { get; set; }

        public PlantDbContext(DbContextOptions<PlantDbContext> options)
            : base(options)
        {
        }
    }
}
