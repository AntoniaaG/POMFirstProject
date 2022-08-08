using NUnit.Framework;
using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Pages
{
    internal class MyAccountPage
    {
        private readonly By _welcomeMessage = By.CssSelector("div > div.welcome-msg > p.hello > strong");

        public void ShowWelcomeMessage()
        {
            string welcomeText = Driver.WebDriver.FindElement(_welcomeMessage).Text;
            Assert.AreEqual(welcomeText, "Hello, antonia sibianu!");
        }
    }
}
