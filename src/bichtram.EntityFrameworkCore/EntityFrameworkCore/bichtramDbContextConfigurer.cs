using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace bichtram.EntityFrameworkCore
{
    public static class bichtramDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<bichtramDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<bichtramDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
