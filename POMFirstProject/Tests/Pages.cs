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
        public static FirstProductPage FirstProductPage => InitPage(new FirstProductPage());
        public static CartPage CartPage => InitPage(new CartPage());
        public static RegisterPage RegisterPage => InitPage(new RegisterPage());
        public static CheckoutPage CheckoutPage => InitPage(new CheckoutPage());
        public static CheckoutSuccessPage CheckoutSuccessPage => InitPage(new CheckoutSuccessPage());
        public static CheckoutPageCheckAsGuest CheckoutPageCheckAsGuest => InitPage(new CheckoutPageCheckAsGuest());

        public static T InitPage<T>(T page)
        {
            PageFactory.InitElements(Driver.WebDriver, page);
            return page;
        }
    }
}
