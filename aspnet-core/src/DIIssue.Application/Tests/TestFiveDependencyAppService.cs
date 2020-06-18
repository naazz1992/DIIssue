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
    public class TestFiveDependencyAppService : ITestFiveDependencyAppService
    {
        private readonly IDIIssueRepository _DIIssueRepository;
        private readonly IDIIssueSecondRepository _DIIssueSecondRepository;
        private readonly IDIIssueThirdRepository _DIIssueThirdRepository;
        private readonly IDIIssueFourthRepository _DIIssueFourthdRepository;
        private readonly IDIIssueFifthRepository _DIIssueFifthRepository;

        public TestFiveDependencyAppService(
            IDIIssueRepository pDIIssueRepository,
            IDIIssueSecondRepository pDIIssueSecondRepository,
            IDIIssueThirdRepository pDIIssueThirdRepository,
            IDIIssueFourthRepository pDIIssueFourthdRepository,
            IDIIssueFifthRepository pDIIssueFifthRepository)
        {
            this._DIIssueRepository = pDIIssueRepository;
            this._DIIssueSecondRepository = pDIIssueSecondRepository;
            this._DIIssueThirdRepository = pDIIssueThirdRepository;
            this._DIIssueFourthdRepository = pDIIssueFourthdRepository;
            this._DIIssueFifthRepository = pDIIssueFifthRepository;
        }

        [HttpGet]
        public void Test()
        {

        }
    }
}
