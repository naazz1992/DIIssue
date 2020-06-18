using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DIIssue.Authorization.Roles;
using DIIssue.Authorization.Users;
using DIIssue.MultiTenancy;
using DIIssue.DIIssues;

namespace DIIssue.EntityFrameworkCore
{
    public class DIIssueDbContext : AbpZeroDbContext<Tenant, Role, User, DIIssueDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<DIIssueSecondEntity> DIIssueSecondEntity { get; set; }
        public DbSet<DIIssueThirdEntity> DIIssueThirdEntity { get; set; }
        public DbSet<DIIssueFourthEntity> DIIssueFourthEntity { get; set; }
        public DbSet<DIIssueFifthEntity> DIIssueFifthEntity { get; set; }
        public DbSet<DIIssueSixthEntity> DIIssueSixthEntity { get; set; }
        public DbSet<DIIssueSeventhEntity> DIIssueSeventhEntity { get; set; }
        public DbSet<DIIssueEigthEntity> DIIssueEigthEntity { get; set; }
        public DbSet<DIIssueNinthEntity> DIIssueNinthEntity { get; set; }

        public DIIssueDbContext(DbContextOptions<DIIssueDbContext> options)
            : base(options)
        {
        }
    }
}
