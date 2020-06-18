using System.Threading.Tasks;
using DIIssue.Models.TokenAuth;
using DIIssue.Web.Controllers;
using Shouldly;
using Xunit;

namespace DIIssue.Web.Tests.Controllers
{
    public class HomeController_Tests: DIIssueWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}