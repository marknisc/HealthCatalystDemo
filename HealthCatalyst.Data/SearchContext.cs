using HealthCatalyst.Models;

using Microsoft.EntityFrameworkCore;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HealthCatalyst.Data
{
    /// <summary>
    /// Implementation of data context for search application
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
            modelBuilder.Entity<Person>()
                .HasMany(_ => (ICollection<Phone>)_.Phones)
                .WithOne()
                .HasForeignKey(_ => _.PersonId);

            modelBuilder.Entity<Person>()
                .HasMany(_ => (ICollection<Address>)_.Addresses)
                .WithOne()
                .HasForeignKey(_ => _.PersonId);

            modelBuilder.Entity<Person>()
                .HasMany(_ => (ICollection<Interest>)_.Interests)
                .WithOne()
                .HasForeignKey(_ => _.PersonId);


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
