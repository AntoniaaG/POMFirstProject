using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMFirstProject.Helpers
{
    internal class WaitHelpers
    {
        public static void WaitUntilDocumentReady()
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30.0))
            .Until(d => Driver.WebDriver.ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
