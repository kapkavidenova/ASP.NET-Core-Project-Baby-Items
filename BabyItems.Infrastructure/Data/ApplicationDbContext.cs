using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BabyItems.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cell> Cells { get; set; }

        public DbSet<Trade> Trades { get; set; }

        public DbSet<TradeStock> TradeStocks { get; set; }

        public DbSet<Contractor> Contractors { get; set; }



        //protected override void OnModelCreating(ModelBuilder builder)
        //{
         

        //    base.OnModelCreating(builder);
        //}

    }
}