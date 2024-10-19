using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentalCar.User.Core.Entities;

namespace RentalCar.User.Infrastructure.Persistence
{
    public class UserContext : IdentityDbContext<ApplicationUser>
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }

    }
}
