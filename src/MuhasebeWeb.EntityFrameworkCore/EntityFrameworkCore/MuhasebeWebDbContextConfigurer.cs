using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MuhasebeWeb.EntityFrameworkCore
{
    public static class MuhasebeWebDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MuhasebeWebDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MuhasebeWebDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
