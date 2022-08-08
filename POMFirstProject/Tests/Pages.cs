using POMFirstProject.Helpers;
using POMFirstProject.Pages;
using SeleniumExtras.PageObjects;

namespace POMFirstProject.Tests
{
    internal class Pages
    {

        public static Header Header => InitPage(new Header());
        public static SearchResultsPage SearchResultsPage => InitPage(new SearchResultsPage());
        public static LoginPage LoginPage => InitPage(new LoginPage());
        public static MyAccountPage MyAccountPage => InitPage(new MyAccountPage());
        public static WomanCategoryPage WomanCategoryPage => InitPage(new WomanCategoryPage());
        public static WomanNewArrivalPage WomanNewArrivalPage => InitPage(new WomanNewArrivalPage());
        public static FirstItemPage FirstItemPage => InitPage(new FirstItemPage());
        public static CartPage CartPage => InitPage(new CartPage());


        public static T InitPage<T>(T page)
        {
            PageFactory.InitElements(Driver.WebDriver, page);
            return page;
        }
    }
}
