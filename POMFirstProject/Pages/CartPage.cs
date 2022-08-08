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
    internal class CartPage
    {
        private readonly By _displayed_message = By.CssSelector("div.cart.display-single-price > ul > li > ul > li > span");

        public void CheckCartPage()
        {
            string messageText = Driver.WebDriver.FindElement(_displayed_message).Text;
            Assert.AreEqual(messageText, "Tori Tank was added to your shopping cart.");
        }
    }
}
