using Microsoft.EntityFrameworkCore;
using ASPCRUDAssignment.Models;

namespace ASPCRUDAssignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}