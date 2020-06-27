using HealthCatalyst.Data;

using Microsoft.EntityFrameworkCore;

using System.Linq;

using Xunit;

namespace HealthCatalyst.UnitTests
{
    public class DataSeederTest
    {
        [Fact]
        public void DataSeed_PersonsCreated()
        {
            SearchContext ctx = new SearchContext();

            var all = ctx.Persons.ToList();

            Assert.Equal(10, all.Count);
        }

        [Fact]
        public void DataSeed_PersonsIncludePhones()
        {
            SearchContext ctx = new SearchContext();

            var all = ctx.Persons.Include("Phones").ToList();

            Assert.Equal(10, all.Count);
            Assert.Equal(2, all[0].Phones.Count);
        }

        [Fact]
        public void DataSeed_AddressesCreated()
        {
            SearchContext ctx = new SearchContext();

            var all = ctx.Addresses.ToList();

            Assert.Equal(10, all.Count);
        }

        [Fact]
        public void DataSeed_InterestsCreated()
        {
            SearchContext ctx = new SearchContext();

            var all = ctx.Interests.ToList();

            Assert.Equal(30, all.Count);
        }

        [Fact]
        public void DataSeed_PhonesCreated()
        {
            SearchContext ctx = new SearchContext();

            var all = ctx.Phones.ToList();

            Assert.Equal(20, all.Count);
        }
    }
}
