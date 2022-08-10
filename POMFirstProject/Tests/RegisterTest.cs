using NUnit.Framework;
using POMFirstProject.Helpers;

namespace POMFirstProject.Tests
{
    [TestFixture]
    internal class RegisterTest : BaseTest
    {
        [Test]
        public void Register()
        {
            Pages.Header.ClickAccount();

            Pages.Header.ClickRegister();

            Pages.RegisterPage.TypeFirstName("Mike");

            Pages.RegisterPage.TypeMiddleName("Josh");

            Pages.RegisterPage.TypeLastName("All");

            Pages.RegisterPage.TypeEmailAddress("all.rty@gmail.com");

            Pages.RegisterPage.TypePassword("aasdfgh");

            Pages.RegisterPage.TypeConfirmPassword("aasdfgh");

            Pages.RegisterPage.ClickRegisterButton();

            Assert.AreEqual("Thank you for registering with Madison Island.", Pages.MyAccountPage.ShowWelcomeMessageForRegistering());
    



        }
    }
}
