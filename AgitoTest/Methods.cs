using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace AgitoTest
{
    public class Methods
    {

        public static IWebDriver ConfigureDriver(IWebDriver driver, string driverType)
        {
            switch (driverType)
            {
                case "Firefox":
                    {
                        driver = new FirefoxDriver();
                        break;
                    }
            }
            
            return driver;
        }

        public static void GoToWebsite(IWebDriver driver ,string websiteURL)
        {
            driver.Navigate().GoToUrl(websiteURL);
            //return driver;
        }

    }
}
