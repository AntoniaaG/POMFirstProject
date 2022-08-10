using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Pages
{
    internal class RegisterPage
    {
        private readonly By _first_name = By.CssSelector("#firstname");
        private readonly By _middle_name = By.CssSelector("#middlename");
        private readonly By _last_name = By.CssSelector("#lastname");
        private readonly By _email_address = By.CssSelector("#email_address");
        private readonly By _password = By.CssSelector("#password");
        private readonly By _confirmation_password = By.CssSelector("#confirmation");
        private readonly By _register_button = By.CssSelector("#form-validate > div.buttons-set > button");

        public void TypeFirstName(string firstName)
        {
            Driver.WebDriver.FindElement(_first_name).SendKeys(firstName);
        }
        public void TypeMiddleName(string middleName)
        {
            Driver.WebDriver.FindElement(_middle_name).SendKeys(middleName);
        }
        public void TypeLastName(string lastName)
        {
            Driver.WebDriver.FindElement(_last_name).SendKeys(lastName);
        }
        public void TypeEmailAddress(string email)
        {
            Driver.WebDriver.FindElement(_email_address).SendKeys(email);
        }
        public void TypePassword(string password)
        {
            Driver.WebDriver.FindElement(_password).SendKeys(password);
        }
        public void TypeConfirmPassword(string confirmationPassword)
        {
            Driver.WebDriver.FindElement(_confirmation_password).SendKeys(confirmationPassword);
        }
        public void ClickRegisterButton()
        {
            Driver.WebDriver.FindElement(_register_button).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
    }
}
