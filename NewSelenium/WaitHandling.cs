using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace NewSelenium
{
    [TestFixture]
    class WaitHandling
    {
        IWebDriver driver;

        [Test]
        public void TestMethodForImplicitWait()
        {
            try
            {
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("https://www.google.pl/");
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                string WaitText = driver.FindElement(By.Id("1234")).Text;
            }
            catch(Exception e)
            {
                Assert.Fail("TestMethodForImplicitWait failed ==> " + e.Message);
            }
            finally
            {
                driver.Quit();
            }
        }

        [Test]
        public void TestMethodForExplicitWait()
        {
            try
            {
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("https://www.google.pl/");
                driver.Manage().Window.Maximize();

                //IWebElement ele = ExplicitWait(driver, "12333");
                if (ExplicitWait(driver, "12333") != null) {
                    string TagNameOfElement = ExplicitWait(driver, "12333").TagName;
                    Assert.IsTrue(true);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail("TestMethodForExplicitWait ==>" + e.Message);
            }
            finally
            {
                driver.Quit();
            }
        }

        public static IWebElement ExplicitWait(IWebDriver driver, string Identifier)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementExists(By.Id(Identifier)));
        }

    }
}
