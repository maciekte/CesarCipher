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
using OpenQA.Selenium.Support.PageObjects;

namespace NewSelenium.Pages
{
    class DashboardPage
    {
        public IWebDriver WebDriver { get; set; }
        public DashboardPage(IWebDriver driver)
        {
            this.WebDriver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
