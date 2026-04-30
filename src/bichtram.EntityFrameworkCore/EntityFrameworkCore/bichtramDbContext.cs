using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using bichtram.Authorization.Roles;
using bichtram.Authorization.Users;
using bichtram.MultiTenancy;

namespace bichtram.EntityFrameworkCore
{
    public class bichtramDbContext : AbpZeroDbContext<Tenant, Role, User, bichtramDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public bichtramDbContext(DbContextOptions<bichtramDbContext> options)
            : base(options)
        {
        }
    }
}
