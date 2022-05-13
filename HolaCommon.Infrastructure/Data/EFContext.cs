using HolaCommon.Domain.Entities.Countries;
using HolaCommon.Domain.Entities.Currencies;
using Microsoft.EntityFrameworkCore;

namespace HolaCommon.Infrastructure.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<Currency> Currency { get; set; }
    }
}
