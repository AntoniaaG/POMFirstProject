using NUnit.Framework;
using POMFirstProject.Helpers;

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
            Pages.WomanNewArrivalPage.ClickFirstProduct();
            Pages.FirstProductPage.ClickColorChoice();
            Pages.FirstProductPage.ClickSizeChoice();
            Pages.FirstProductPage.SetQuantity();
            Pages.FirstProductPage.ClickAddToCartButton();

            Assert.AreEqual(1, Pages.Header.GetMiniCart());

        }
    }
}
