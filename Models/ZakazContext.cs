using Microsoft.EntityFrameworkCore;

namespace TP_Controller.Models
{
    public class ZakazContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ZakazContext(DbContextOptions<ZakazContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
