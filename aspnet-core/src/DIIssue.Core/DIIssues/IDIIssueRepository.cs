﻿using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIIssue.DIIssues
{
    public interface IDIIssueRepository : IRepository<DIIssueEntity> 
    {
    }
}
