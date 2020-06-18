using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DIIssue.EntityFrameworkCore
{
    public static class DIIssueDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DIIssueDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DIIssueDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
