using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;



namespace AgitoTest
{
    [TestFixture]
    class Program
    {
        private IWebDriver driver;
        private IWebElement _inputBoxElement;
        private IWebElement _searchButtonElement;

        static void Main(string[] args)
        { 
            
        }

        [Test]
        public void NavigateToAgito()
        {
            driver = Methods.ConfigureDriver(driver, "Firefox");
            Methods.GoToWebsite(driver, Parameters.AgitoURL);
            _inputBoxElement = driver.FindElement(Parameters.searchInputBoxClass);

            _inputBoxElement.Clear();
            _inputBoxElement.SendKeys("kuchenka");

        }
    }
}


//this is content for commit