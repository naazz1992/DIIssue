using Abp.EntityFrameworkCore;
using DIIssue.DIIssues;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIIssue.EntityFrameworkCore.Repositories
{
    public class DIIssueThirdRepository : DIIssueRepositoryBase<DIIssueThirdEntity>, IDIIssueThirdRepository
    {
        public DIIssueThirdRepository(IDbContextProvider<DIIssueDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
