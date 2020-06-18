using Abp.EntityFrameworkCore;
using DIIssue.DIIssues;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIIssue.EntityFrameworkCore.Repositories
{
    public class DIIssueSeventhRepository : DIIssueRepositoryBase<DIIssueSeventhEntity>, IDIIssueSeventhRepository
    {
        public DIIssueSeventhRepository(IDbContextProvider<DIIssueDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
