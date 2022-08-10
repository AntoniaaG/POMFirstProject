using NUnit.Framework;
using POMFirstProject.Helpers;

namespace POMFirstProject.Tests
{
    [TestFixture]
    internal class LoginTest : BaseTest
    {
        [Test]
        public void Login()
        {
            Pages.Header.ClickAccount();

            Pages.Header.ClickLogin();

            Pages.LoginPage.TypeEmail("antonia@gmail.com");

            Pages.LoginPage.TypePassword("asdfgh");

            Pages.LoginPage.LoginButton();

            Pages.MyAccountPage.ShowWelcomeMessage();

        }
    }
}
