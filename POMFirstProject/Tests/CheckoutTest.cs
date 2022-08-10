using NUnit.Framework;
using POMFirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Tests
{
    [TestFixture]
    internal class CheckoutTest : BaseTest
    {
        [Test]
        public void Checkout()
        {
            Pages.Header.ClickWomenCategory();
            Pages.WomanCategoryPage.ClickNewArrivals();
            Pages.WomanNewArrivalPage.ClickFirstProduct();
            Pages.FirstProductPage.ClickColorChoice();
            Pages.FirstProductPage.ClickSizeChoice();
            Pages.FirstProductPage.SetQuantity();
            Pages.FirstProductPage.ClickAddToCartButton();
            Pages.CartPage.ClickProceedToCheckoutButton();
            Pages.CheckoutPageCheckAsGuest.ClickAsGuest();
            Pages.CheckoutPageCheckAsGuest.ClickContinueButton();
            Pages.CheckoutPage.TypeFirstName("johana");
            Pages.CheckoutPage.TypeMiddleName("rick");
            Pages.CheckoutPage.TypeLastName("madi");
            Pages.CheckoutPage.TypeCompany("impeq");
            Pages.CheckoutPage.TypeEmail("jojo@yahoo.com");
            Pages.CheckoutPage.TypeAddress("streeast ro 34/454");
            Pages.CheckoutPage.TypeAddress2("streasdet eu 22/222");
            Pages.CheckoutPage.TypeCity("new aderew");
            Pages.CheckoutPage.ClickStateList();
            Pages.CheckoutPage.ClickState();
            Pages.CheckoutPage.TypePostalCode("245454");
            Pages.CheckoutPage.TypeTelephone("077040555666");
            Pages.CheckoutPage.TypeFax("004055775666");
            Pages.CheckoutPage.ClickShipToThisAddress();
            Pages.CheckoutPage.ClickContinueButton();
            Pages.CheckoutPage.ClickShippingInformation();

            Pages.CheckoutPage.TypeFirstNameShipping("johana");
            Pages.CheckoutPage.TypeMiddleNameShipping("madi");
            Pages.CheckoutPage.TypeLastNameShipping("rick");
            Pages.CheckoutPage.TypeCompanyShipping("impdssasex");
            Pages.CheckoutPage.TypeAddressShipping("streeast ro 3422/4");
            Pages.CheckoutPage.TypeAddress2Shipping("streasdet eu 2222/2");
            Pages.CheckoutPage.TypeCityShipping("new adrew");
            Pages.CheckoutPage.ClickStateListShipping();
            Pages.CheckoutPage.ClickStateShipping();
            Pages.CheckoutPage.TypePostalCodeShipping("111444");
            Pages.CheckoutPage.TypeTelephoneShipping("00405556623216");
            Pages.CheckoutPage.TypeFaxShipping("0040555134325666");

            Pages.CheckoutPage.ClickContinueButtonShippingInformation();
            Pages.CheckoutPage.ClickContinueButtonShippingMethod();
            Pages.CheckoutPage.ClickContinueButtonPaymentInformation();
            Pages.CheckoutPage.ClickPlaceOrderButton();

            Assert.AreEqual("Your order # is: 145000028.", Pages.CheckoutSuccessPage.CheckConfirmationOrderMessage());
            //adauga la nr comenzii plus unu
        }
    }
}
