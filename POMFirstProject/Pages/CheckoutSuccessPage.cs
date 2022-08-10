using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Pages
{
    internal class CheckoutSuccessPage
    {
        private readonly By _displayed_message = By.CssSelector("div.col-main > p");

        public string CheckConfirmationOrderMessage()
        {
            var text = Driver.WebDriver.FindElement(_displayed_message).Text;
            return text;
        }
    }
}
