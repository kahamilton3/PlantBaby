using PlantBaby.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PlantBaby.Data
{
    public class PlantDbContext : IdentityDbContext<IdentityUser>
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
