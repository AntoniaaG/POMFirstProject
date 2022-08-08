using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Pages
{
    internal class WomanNewArrivalPage
    {
        private readonly By _first_item = By.CssSelector("div.category-products > ul > li:nth-child(1) > a");

        public void ClickItem()
        {
            Driver.WebDriver.FindElement(_first_item).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
    }
}
