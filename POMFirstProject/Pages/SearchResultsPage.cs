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
    internal class SearchResultsPage
    {

        private readonly By _searchResult = By.CssSelector("div.col-wrapper > div.col-main > p");

        public void CheckResultPage()
        {
            string messageText = Driver.WebDriver.FindElement(_searchResult).Text;
            Assert.AreEqual(messageText, "You're search returns no results.");
        }
    }
}
