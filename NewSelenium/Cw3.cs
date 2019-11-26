using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;


namespace NewSelenium
{
    class Cw3
    {
        IWebDriver m_driver;

        [SetUp]
        public void Preparation()
        {
            m_driver = new FirefoxDriver();
        }

        [Test]
        public void Test()
        {
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            try
            {
                IWebElement linkSAP = m_driver.FindElement(By.LinkText("SAP"));
                linkSAP.Click();

                IWebElement link = m_driver.FindElement(By.CssSelector("input[id='awf_field-91977688']"));
                link.SendKeys("test123@gmail.com");

                IWebElement listbox = m_driver.FindElement(By.CssSelector("[id='awf_field-91977689']"));
                var selectTest = new SelectElement(listbox);
                selectTest.SelectByValue("sap-abap");

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("not found item " + e);
            }

        }
        [TearDown]
        public void TestFinish()
        {
            m_driver.Close();
            //any comment for GIT commit
        }

    }
}
