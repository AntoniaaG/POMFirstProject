using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Helpers
{
    internal class BaseTest
    {

        [SetUp]
        public void Setup()
        {
            Driver.WebDriver = new ChromeDriver("C:\\Users\\rartu\\source\\repos");
            Driver.WebDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com/");
            WaitHelpers.WaitUntilDocumentReady();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.WebDriver.Close();
            Driver.WebDriver.Quit();
        }
    }
}
