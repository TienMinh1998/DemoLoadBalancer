using HolaCore.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace HolaCore.Infrastructure.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
