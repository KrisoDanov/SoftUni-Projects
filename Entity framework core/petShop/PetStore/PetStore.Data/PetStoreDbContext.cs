using Microsoft.EntityFrameworkCore;
using PetSore.Common;
using PetSoreModels;

namespace PetStore.Data
{
    public class PetStoreDbContext : DbContext
    {
        public PetStoreDbContext()
        {

        }
        public PetStoreDbContext(DbContextOptions dbContextOptions)
            : base (dbContextOptions)
        {

        }

        public DbSet<Breed> Breeds{ get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientProduct> ClientProducts { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Pet> Pets{ get; set; }
        public DbSet<Products> Products{ get; set; }

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfiguration.DefaultConnectionString);

            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PetStoreDbContext).Assembly);

        }
    }
}
