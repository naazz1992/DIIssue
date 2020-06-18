using Abp.EntityFrameworkCore;
using DIIssue.DIIssues;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIIssue.EntityFrameworkCore.Repositories
{
    public class DIIssueNinthRepository : DIIssueRepositoryBase<DIIssueNinthEntity>, IDIIssueNinthRepository
    {
        public DIIssueNinthRepository(IDbContextProvider<DIIssueDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
