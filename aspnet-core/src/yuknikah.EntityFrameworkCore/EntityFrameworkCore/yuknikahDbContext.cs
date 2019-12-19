using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using yuknikah.Authorization.Roles;
using yuknikah.Authorization.Users;
using yuknikah.MultiTenancy;

namespace yuknikah.EntityFrameworkCore
{
    public class yuknikahDbContext : AbpZeroDbContext<Tenant, Role, User, yuknikahDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public yuknikahDbContext(DbContextOptions<yuknikahDbContext> options)
            : base(options)
        {
        }
    }
}
