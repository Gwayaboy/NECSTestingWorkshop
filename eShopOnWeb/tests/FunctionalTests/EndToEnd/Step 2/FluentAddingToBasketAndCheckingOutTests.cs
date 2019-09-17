using Microsoft.eShopWeb.FunctionalTests.EndToEnd.Configuration;
using Microsoft.eShopWeb.FunctionalTests.EndToEnd.Pages;
using Microsoft.eShopWeb.FunctionalTests.EndToEnd.Step_2.Assertions;
using Microsoft.eShopWeb.FunctionalTests.EndToEnd.ViewModels;
using Xunit;

namespace Microsoft.eShopWeb.FunctionalTests.EndToEnd.Step_2
{
    [Trait("Category", "EndToEnd")]

    public class AddingToBasketAndCheckingOutTests : Specs
    {
        public AddingToBasketAndCheckingOutTests() : base(BrowserHost.Chrome) { }

        [Fact]
        public void Can_add_selected_item_basket()
        {
            //Arrange
            var homePage = Browser.NavigateToInitial<HomePage>("http://localhost:5106");
            var expectedDotNetBlackAndWhiteMug = new ProductViewModel { Description = ".NET Black & White Mug" };

            //Act
            var actualPage = homePage.AddToBasketByProductId(2);

            //Assert
            actualPage
                .Should()
                .Be<BasketPage>(withExpectedTitle: "Basket - Microsoft.eShopOnWeb")
                               .And
                               .OnlyHave(expectedDotNetBlackAndWhiteMug);
        }

    }
}
