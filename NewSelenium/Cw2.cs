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
    class Cw2
    {
        IWebDriver driver;

        [SetUp]
        public void Preparation()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();
            try
            {
                IWebElement link = driver.FindElement(By.LinkText("Testing"));
                link.Click();
            } catch (NoSuchElementException e)
            {
                Console.WriteLine("not found item " + e);
            }
            
        }
        [TearDown]
        public void TestFinish()
        {
            driver.Close();
        }
    }
}
