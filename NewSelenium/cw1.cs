using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace NewSelenium
{
    class Cw1
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.pl";
        }
        [TearDown]
        public void Finish()
        {
            driver.Close();
        }
    }
}
