using NUnit.Framework;
using OpenQA.Selenium;
using POMFirstProject.Helpers;

namespace POMFirstProject.Pages
{
    internal class CartPage
    {
        private readonly By _displayed_message = By.CssSelector("div.cart.display-single-price > ul > li > ul > li > span");
        private readonly By _proceed_to_checkout_button = By.CssSelector("div.page-title.title-buttons > ul > li > button");

        public void CheckCartPage()
        {
            string messageText = Driver.WebDriver.FindElement(_displayed_message).Text;
            Assert.AreEqual(messageText, "Tori Tank was added to your shopping cart.");
        }

        public void ClickProceedToCheckoutButton()
        {
            Driver.WebDriver.FindElement(_proceed_to_checkout_button).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
    }
}
