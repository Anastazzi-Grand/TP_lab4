using Microsoft.EntityFrameworkCore;

namespace TP_Controller.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;

        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
