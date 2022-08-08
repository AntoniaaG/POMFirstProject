using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Pages
{
    internal class Header
    {
        private readonly By _language_list = By.CssSelector("#select-language");
        private readonly By _logo = By.CssSelector(".logo");
        private readonly By _welcome_msg_text = By.CssSelector(".welcome-msg");

        private readonly By _account = By.CssSelector(".skip-link.skip-account");
        private readonly By _account_list = By.CssSelector("#header-account .links li");
        private readonly By _my_account_option = By.CssSelector("#header-account > li.first > a");
        private readonly By _my_wishlist_option = By.CssSelector("#header-account > li:nth-child(2) > a");
        private readonly By _my_cart_option = By.CssSelector("#header-account > li:nth-child(3) > a");
        private readonly By _checkout_option = By.CssSelector("#header-account > li:nth-child(4) > a");
        private readonly By register_option = By.CssSelector("#header-account > li:nth-child(5) > a");
        private readonly By _login_option = By.CssSelector("#header-account > div > ul > li.last");

        private readonly By _search_field = By.CssSelector("#search");
        private readonly By _search_button = By.CssSelector(".button.search-button");
        private readonly By _category_list = By.CssSelector(".nav-primary > li");
        private readonly By _woman_category = By.CssSelector("li.level0.nav-1.first.active.parent > a");

        private readonly By _minicart = By.CssSelector(".header-minicart");
        private readonly By _minicart_products_list = By.CssSelector(".mini-products-list");
        private readonly By _minicart_subtotal = By.CssSelector(".subtotal .price");
        private readonly By _minicart_add_button = By.CssSelector(".button.checkout-button");
        private readonly By _minicart_cart_button = By.CssSelector(".cart-link");

        public void ClickLogo()
        {
            Driver.WebDriver.FindElement(_logo).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickAccount()
        {
            Driver.WebDriver.FindElement(_account).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }

        public void ClickAccountList()
        {
            Driver.WebDriver.FindElement(_account_list).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickMyAccount()
        {
            Driver.WebDriver.FindElement(_my_account_option).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickMyWishList()
        {
            Driver.WebDriver.FindElement(_my_wishlist_option).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickMyCart()
        {
            Driver.WebDriver.FindElement(_my_cart_option).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickCheckout()
        {
            Driver.WebDriver.FindElement(_checkout_option).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickRegister()
        {
            Driver.WebDriver.FindElement(register_option).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickLogin()
        {
            Driver.WebDriver.FindElement(_login_option).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickWomenCategory()
        {
            Driver.WebDriver.FindElement(_woman_category).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }

        public void Search(string SearchString)
        {
            Driver.WebDriver.FindElement(_search_field).SendKeys(SearchString);
            Driver.WebDriver.FindElement(_search_button).Click();
        }
    }
}
