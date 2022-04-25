

using Microsoft.EntityFrameworkCore;
using ShopYT.Data.Models;

namespace ShopYT.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base (options)
        {
          //  Database.EnsureDeleted();
            Database.EnsureCreated();
           
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
