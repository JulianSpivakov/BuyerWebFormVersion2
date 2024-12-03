using BuyerWebFormVersion2.Models;
using Microsoft.EntityFrameworkCore;

namespace BuyerWebFormVersion2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public virtual DbSet<BuyerWebForm> BuyerWebForm { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BuyerWebForm>();
        }

    }
}
