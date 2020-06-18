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
    public class TestNineDependencyAppService : ITestNineDependencyAppService
    {
        private readonly IDIIssueRepository _DIIssueRepository;
        private readonly IDIIssueSecondRepository _DIIssueSecondRepository;
        private readonly IDIIssueThirdRepository _DIIssueThirdRepository;
        private readonly IDIIssueFourthRepository _DIIssueFourthdRepository;
        private readonly IDIIssueFifthRepository _DIIssueFifthRepository;
        private readonly IDIIssueSixthRepository _DIIssueSixthRepository;
        private readonly IDIIssueSeventhRepository _DIIssueSeventhRepository;
        private readonly IDIIssueEigthRepository _DIIssueEigthRepository;
        private readonly IDIIssueNinthRepository _DIIssueNinthRepository;

        public TestNineDependencyAppService(
            IDIIssueRepository pDIIssueRepository,
            IDIIssueSecondRepository pDIIssueSecondRepository,
            IDIIssueThirdRepository pDIIssueThirdRepository,
            IDIIssueFourthRepository pDIIssueFourthdRepository,
            IDIIssueFifthRepository pDIIssueFifthRepository,
            IDIIssueSixthRepository pDIIssueSixthRepository,
            IDIIssueSeventhRepository pDIIssueSeventhRepository,
            IDIIssueEigthRepository pDIIssueEigthRepository,
            IDIIssueNinthRepository pDIIssueNinthRepository)
        {
            this._DIIssueRepository = pDIIssueRepository;
            this._DIIssueSecondRepository = pDIIssueSecondRepository;
            this._DIIssueThirdRepository = pDIIssueThirdRepository;
            this._DIIssueFourthdRepository = pDIIssueFourthdRepository;
            this._DIIssueFifthRepository = pDIIssueFifthRepository;
            this._DIIssueSixthRepository = pDIIssueSixthRepository;
            this._DIIssueSeventhRepository = pDIIssueSeventhRepository;
            this._DIIssueEigthRepository = pDIIssueEigthRepository;
            this._DIIssueNinthRepository = pDIIssueNinthRepository;
        }

        [HttpGet]
        public void Test()
        {

        }
    }
}
