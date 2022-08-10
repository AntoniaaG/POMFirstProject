using OpenQA.Selenium;
using POMFirstProject.Helpers;

namespace POMFirstProject.Pages
{
    internal class WomanNewArrivalPage
    {
        private readonly By _first_item = By.CssSelector("div.category-products > ul > li:nth-child(1) > a");

        public void ClickFirstProduct()
        {
            Driver.WebDriver.FindElement(_first_item).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
    }
}
