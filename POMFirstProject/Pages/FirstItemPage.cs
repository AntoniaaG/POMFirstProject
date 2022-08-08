using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Pages
{
    internal class FirstItemPage
    {
        private readonly By _color_blue_choice = By.CssSelector("#swatch26");
        private readonly By _size_m_choice = By.CssSelector("#swatch79");
        private readonly By _quantity = By.CssSelector("#qty");
        private readonly By _add_to_cart_button = By.CssSelector("div.add-to-cart-buttons > button > span > span");

        public void ClickColorChoice()
        {
            Driver.WebDriver.FindElement(_color_blue_choice).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickSizeChoice()
        {
            Driver.WebDriver.FindElement(_size_m_choice).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void SetQuantity()
        {
            Driver.WebDriver.FindElement(_quantity).Clear();
            Driver.WebDriver.FindElement(_quantity).Click();
            Driver.WebDriver.FindElement(_quantity).SendKeys("1");
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickAddToCartButton()
        {
            Driver.WebDriver.FindElement(_add_to_cart_button).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
    }
}
