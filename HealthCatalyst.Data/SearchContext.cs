using HealthCatalyst.Models;

using Microsoft.EntityFrameworkCore;

namespace HealthCatalyst.Data
{
    /// <summary>
    /// Implementation of data contexxt for search application
    /// </summary>
    public class SearchContext : DbContext
    {
        public SearchContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=healthcatalyst.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var persons = DataSeeder.GeneratePersons();

            modelBuilder.Entity<Person>().HasData(persons);
            modelBuilder.Entity<Phone>().HasData(DataSeeder.GeneratePhones(persons));
            modelBuilder.Entity<Address>().HasData(DataSeeder.GenerateAddresses(persons));
            modelBuilder.Entity<Interest>().HasData(DataSeeder.GenerateInterests(persons));
        }

        #region Properties

        public DbSet<Person> Persons { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Address> Addresses { get; set; }

        #endregion
    }
}
