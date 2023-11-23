using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AutopartsRepository.Contexts
{
    public class AutopartsDbContext : DbContext /*IdentityDbContext<AutopartsUser, AutopartsRole, string>*/
    {
        public AutopartsDbContext(DbContextOptions options) : base(options)
        {
        }

        public AutopartsDbContext()
        {
        }

        // DbSet -> AutopartsEntity/Identity/Entities


        // DbSet -> AutopartsEntity/Catalog/Entities
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Warranty> Warranties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}