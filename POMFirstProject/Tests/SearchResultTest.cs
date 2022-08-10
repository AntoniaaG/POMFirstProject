using NUnit.Framework;
using POMFirstProject.Helpers;

namespace POMFirstProject.Tests
{
    [TestFixture]
    internal class SearchResultTest : BaseTest
    {
        [Test]
        public void SearchTest()
        {
            Pages.Header.Search("dress");

            Pages.SearchResultsPage.CheckResultPage();
        }

    }
}
