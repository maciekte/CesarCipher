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
    class HomePage
    {
        public IWebDriver Driver { get; set; }

        [FindsBy(How=How.Name, Using = "login")]
        public IWebElement LoginField { get; set; }

        [FindsBy(How=How.Name, Using = "haslo")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.ClassName, Using = "FormButton_02")]
        public IWebElement SubmitButton { get; set; }


        public HomePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public DashboardPage LoginOnPage(string login, string password)
        {
            LoginField.SendKeys(login);
            PasswordField.SendKeys(password);
            SubmitButton.Click();
            return new DashboardPage(Driver);
        }


    }
}
