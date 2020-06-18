using Abp.EntityFrameworkCore;
using DIIssue.DIIssues;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIIssue.EntityFrameworkCore.Repositories
{
    public class DIIssueSixthRepository : DIIssueRepositoryBase<DIIssueSixthEntity>, IDIIssueSixthRepository
    {
        public DIIssueSixthRepository(IDbContextProvider<DIIssueDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
