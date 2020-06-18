using Microsoft.AspNetCore.Mvc;
using DIIssue.Authorization.Roles;
using DIIssue.Authorization.Users;
using DIIssue.Editions;
using DIIssue.DIIssues;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIIssue.Tests
{
    public class TestOneDependencyAppService : ITestOneDependencyAppService
    {
        private readonly IDIIssueRepository _DIIssueRepository;

        public TestOneDependencyAppService(IDIIssueRepository pDIIssueRepository)
        {
            this._DIIssueRepository = pDIIssueRepository;
        }

        [HttpGet]
        public void Test()
        {

        }
    }
}
