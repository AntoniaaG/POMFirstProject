using OpenQA.Selenium;
using POMFirstProject.Helpers;

namespace POMFirstProject.Pages
{
    internal class WomanCategoryPage
    {
        private readonly By _woman_new_arrivals = By.CssSelector("div.col-main > ul > li:nth-child(1)");

        public void ClickNewArrivals()
        {
            Driver.WebDriver.FindElement(_woman_new_arrivals).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
    }
    
}
