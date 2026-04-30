using System.Threading.Tasks;
using bichtram.Models.TokenAuth;
using bichtram.Web.Controllers;
using Shouldly;
using Xunit;

namespace bichtram.Web.Tests.Controllers
{
    public class HomeController_Tests: bichtramWebTestBase
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