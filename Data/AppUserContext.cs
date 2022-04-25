using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShopYT.Data.Models
{
    public class AppUserContext:IdentityDbContext<User>
    {
        public AppUserContext(DbContextOptions<AppUserContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
