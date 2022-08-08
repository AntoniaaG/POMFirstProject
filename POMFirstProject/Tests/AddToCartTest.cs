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
    internal class AddToCartTest : BaseTest
    {
        [Test]
        public void AddToCart()
        {
            Pages.Header.ClickWomenCategory();
            Pages.WomanCategoryPage.ClickNewArrivals();
            Pages.WomanNewArrivalPage.ClickItem();
            Pages.FirstItemPage.ClickColorChoice();
            Pages.FirstItemPage.ClickSizeChoice();
            Pages.FirstItemPage.SetQuantity();
            Pages.FirstItemPage.ClickAddToCartButton();
            Pages.CartPage.CheckCartPage();

        }
    }
}
