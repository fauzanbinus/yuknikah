using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace yuknikah.EntityFrameworkCore
{
    public static class yuknikahDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<yuknikahDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<yuknikahDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
