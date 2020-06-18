using Abp.EntityFrameworkCore;
using DIIssue.DIIssues;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIIssue.EntityFrameworkCore.Repositories
{
    public class DIIssueSecondRepository : DIIssueRepositoryBase<DIIssueSecondEntity>, IDIIssueSecondRepository
    {
        public DIIssueSecondRepository(IDbContextProvider<DIIssueDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
