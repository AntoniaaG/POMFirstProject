using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;

namespace POMFirstProject.Pages
{
    internal class LoginPage
    {

        private readonly By _emailAddress = By.CssSelector("#email");
        private readonly By _password = By.CssSelector("#pass");
        private readonly By _loginButton = By.CssSelector("#send2");


        public void TypeEmail(String email)
        {
            Driver.WebDriver.FindElement(_emailAddress).SendKeys(email);
        }
        public void TypePassword(String password)
        {
            Driver.WebDriver.FindElement(_password).SendKeys(password);
        }
        public void LoginButton()
        {
            Driver.WebDriver.FindElement(_loginButton).Click();
        }

    }
}
