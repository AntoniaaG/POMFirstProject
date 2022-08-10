using NUnit.Framework;
using OpenQA.Selenium;
using POMFirstProject.Helpers;

namespace POMFirstProject.Pages
{
    internal class MyAccountPage
    {
        private readonly By _welcome_message_login = By.CssSelector("div > div.welcome-msg > p.hello > strong");
        private readonly By _welcome_message_register = By.CssSelector("body > div > div > div.main-container.col2-left-layout > div > div.col-main > div.my-account > div > ul > li > ul > li > span");


        public void ShowWelcomeMessage()
        {
            string welcomeText = Driver.WebDriver.FindElement(_welcome_message_login).Text;
            Assert.AreEqual(welcomeText, "Hello, antonia sibianu!");
        }

        public string ShowWelcomeMessageForRegistering()
        {
            var text = Driver.WebDriver.FindElement(_welcome_message_register).Text;
            return text;
        }
    }
}
