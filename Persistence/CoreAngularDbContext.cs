using ASP.NET_Core_Angular_4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ASP.NET_Core_Angular_4.Persistence
{
    public class CoreAngularDbContext : DbContext
    {
        public CoreAngularDbContext(DbContextOptions<CoreAngularDbContext> options) : base(options) {

        }

        public DbSet<Make> Makes { get; set; }
    }
}