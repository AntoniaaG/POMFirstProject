using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;

namespace POMFirstProject.Pages
{
    internal class LoginPage
    {

        private readonly By _email_address = By.CssSelector("#email");
        private readonly By _password = By.CssSelector("#pass");
        private readonly By _login_button = By.CssSelector("#send2");


        public void TypeEmail(String email)
        {
            Driver.WebDriver.FindElement(_email_address).SendKeys(email);
        }
        public void TypePassword(String password)
        {
            Driver.WebDriver.FindElement(_password).SendKeys(password);
        }
        public void LoginButton()
        {
            Driver.WebDriver.FindElement(_login_button).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }

    }
}
