using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DIIssue.Configuration;
using DIIssue.Web;

namespace DIIssue.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DIIssueDbContextFactory : IDesignTimeDbContextFactory<DIIssueDbContext>
    {
        public DIIssueDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DIIssueDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DIIssueDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DIIssueConsts.ConnectionStringName));

            return new DIIssueDbContext(builder.Options);
        }
    }
}
