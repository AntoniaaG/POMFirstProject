using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Pages
{
    internal class CheckoutPageCheckAsGuest
    {
        private readonly By _check_as_guest = By.CssSelector("#login\\:guest");
        private readonly By _continue_button = By.CssSelector("#onepage-guest-register-button");

        public void ClickAsGuest()
        {
            Driver.WebDriver.FindElement(_check_as_guest).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickContinueButton()
        {
            Driver.WebDriver.FindElement(_continue_button).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
    }
}
