using OpenQA.Selenium;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Pages
{
    internal class CheckoutPage
    {
        private readonly By _first_name = By.CssSelector("#billing\\:firstname");
        private readonly By _middle_name = By.CssSelector("#billing\\:middlename");
        private readonly By _last_name = By.CssSelector("#billing\\:lastname");
        private readonly By _company = By.CssSelector("#billing\\:company");
        private readonly By _email = By.CssSelector("#billing\\:email");
        private readonly By _address = By.CssSelector("#billing\\:street1");
        private readonly By _address2 = By.CssSelector("#billing\\:street2");
        private readonly By _city = By.CssSelector("#billing\\:city");
        private readonly By _state_list = By.CssSelector("#billing\\:region_id > option:nth-child(1)");
        private readonly By _state = By.CssSelector("#billing\\:region_id > option:nth-child(2)");
        private readonly By _postal_code = By.CssSelector("#billing\\:postcode");
        private readonly By _country_list = By.CssSelector("#billing\\:country_id");
        private readonly By _country = By.CssSelector("#shipping\\:country_id");
        private readonly By _telephone = By.CssSelector("#billing\\:telephone");
        private readonly By _fax = By.CssSelector("#billing\\:fax");
        private readonly By _ship_to_this_address = By.CssSelector("#billing\\:use_for_shipping_yes");
        private readonly By _ship_to_different_address = By.CssSelector("#billing\\:use_for_shipping_no");
        private readonly By _continue_button = By.CssSelector("#billing-buttons-container > button");

        private readonly By _shipping_information = By.CssSelector("#opc-shipping > div.step-title");
        private readonly By _first_name_shipping = By.CssSelector("#shipping\\:firstname");
        private readonly By _middle_name_shipping = By.CssSelector("#shipping\\:middlename");
        private readonly By _last_name_shipping = By.CssSelector("#shipping\\:lastname");
        private readonly By _company_shipping = By.CssSelector("#shipping\\:company");
        private readonly By _address_shipping = By.CssSelector("#shipping\\:street1");
        private readonly By _address2_shipping = By.CssSelector("#shipping\\:street2");
        private readonly By _city_shipping = By.CssSelector("#shipping\\:city");
        private readonly By _state_list_shipping = By.CssSelector("#shipping\\:region_id > option:nth-child(1)");
        private readonly By _state_shipping = By.CssSelector("#shipping\\:region_id > option:nth-child(2)");
        private readonly By _postal_code_shipping = By.CssSelector("#shipping\\:postcode");
        private readonly By _country_list_shipping = By.CssSelector("#shipping\\:country_id");
        private readonly By _country_shipping = By.CssSelector("#shipping\\:country_id");
        private readonly By _telephone_shipping = By.CssSelector("#shipping\\:telephone");
        private readonly By _fax_shipping = By.CssSelector("#shipping\\:fax");

        private readonly By _continue_button_shipping_information = By.CssSelector("#shipping-buttons-container > button");
        private readonly By _continue_button_shipping_method = By.CssSelector("#shipping-method-buttons-container > button");
        private readonly By _continue_button_payment_information = By.CssSelector("#payment-buttons-container > button");
        private readonly By _place_order_button = By.CssSelector("#review-buttons-container > button");


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
        public void TypeCompany(string company)
        {
            Driver.WebDriver.FindElement(_company).SendKeys(company);
        }
        public void TypeEmail(string email)
        {
            Driver.WebDriver.FindElement(_email).SendKeys(email);
        }
        public void TypeAddress(string address)
        {
            Driver.WebDriver.FindElement(_address).SendKeys(address);
        }
        public void TypeAddress2(string address2)
        {
            Driver.WebDriver.FindElement(_address2).SendKeys(address2);
        }

        public void TypeCity(string city)
        {
            Driver.WebDriver.FindElement(_city).SendKeys(city);
        }
        public void ClickStateList()
        {
            Driver.WebDriver.FindElement(_state_list).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickState()
        {
            Driver.WebDriver.FindElement(_state).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void TypePostalCode(string postalcode)
        {
            Driver.WebDriver.FindElement(_postal_code).SendKeys(postalcode);
        }
        public void ClickCountryList()
        {
            Driver.WebDriver.FindElement(_country_list).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickCountry()
        {
            Driver.WebDriver.FindElement(_country).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void TypeTelephone(string telephone)
        {
            Driver.WebDriver.FindElement(_telephone).SendKeys(telephone);
        }
        public void TypeFax(string fax)
        {
            Driver.WebDriver.FindElement(_fax).SendKeys(fax);
        }
        public void ClickShipToThisAddress()
        {
            Driver.WebDriver.FindElement(_ship_to_this_address).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickShipToDifferentAddress()
        {
            Driver.WebDriver.FindElement(_ship_to_different_address).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickContinueButton()
        {
            Driver.WebDriver.FindElement(_continue_button).Click();
            //WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickShippingInformation()
        {
            Driver.WebDriver.FindElement(_shipping_information).Click();
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickContinueButtonShippingInformation()
        {
            Driver.WebDriver.FindElement(_continue_button_shipping_information).Click();
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickContinueButtonShippingMethod()
        {
            Driver.WebDriver.FindElement(_continue_button_shipping_method).Click();
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickContinueButtonPaymentInformation()
        {
            Driver.WebDriver.FindElement(_continue_button_payment_information).Click();
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickPlaceOrderButton()
        {
            Driver.WebDriver.FindElement(_place_order_button).Click();
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void TypeFirstNameShipping(string firstName)
        {
            Driver.WebDriver.FindElement(_first_name_shipping).SendKeys(firstName);
        }
        public void TypeMiddleNameShipping(string middleName)
        {
            Driver.WebDriver.FindElement(_middle_name_shipping).SendKeys(middleName);
        }
        public void TypeLastNameShipping(string lastName)
        {
            Driver.WebDriver.FindElement(_last_name_shipping).SendKeys(lastName);
        }
        public void TypeCompanyShipping(string company)
        {
            Driver.WebDriver.FindElement(_company_shipping).SendKeys(company);
        }
        public void TypeAddressShipping(string address)
        {
            Driver.WebDriver.FindElement(_address_shipping).SendKeys(address);
        }
        public void TypeAddress2Shipping(string address2)
        {
            Driver.WebDriver.FindElement(_address2_shipping).SendKeys(address2);
        }

        public void TypeCityShipping(string city)
        {
            Driver.WebDriver.FindElement(_city_shipping).SendKeys(city);
        }
        public void ClickStateListShipping()
        {
            Driver.WebDriver.FindElement(_state_list_shipping).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickStateShipping()
        {
            Driver.WebDriver.FindElement(_state_shipping).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void TypePostalCodeShipping(string postalcode)
        {
            Driver.WebDriver.FindElement(_postal_code_shipping).SendKeys(postalcode);
        }
        public void ClickCountryListShipping()
        {
            Driver.WebDriver.FindElement(_country_list_shipping).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void ClickCountryShipping()
        {
            Driver.WebDriver.FindElement(_country_shipping).Click();
            WaitHelpers.WaitUntilDocumentReady();
        }
        public void TypeTelephoneShipping(string telephone)
        {
            Driver.WebDriver.FindElement(_telephone_shipping).SendKeys(telephone);
        }
        public void TypeFaxShipping(string fax)
        {
            Driver.WebDriver.FindElement(_fax_shipping).SendKeys(fax);
        }
    }
}
