using Abp.Zero.EntityFrameworkCore;
using bichtram.Authorization.Roles;
using bichtram.Authorization.Users;
using bichtram.Brands;
using bichtram.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace bichtram.EntityFrameworkCore
{
    public class bichtramDbContext : AbpZeroDbContext<Tenant, Role, User, bichtramDbContext>
    {

        public virtual DbSet<Brand> Brands { get; set; }

        public bichtramDbContext(DbContextOptions<bichtramDbContext> options)
            : base(options)
        {
        }
    }
}
