using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace Twitter_PF
{
    [TestFixture]
    class TwitterLoginPF
    {
        [Test]
        public void VerifyTwitterLogin()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://twitter.com/login?lang=pl");

            LoginPagePF loginPF = new LoginPagePF();
            PageFactory.InitElements(driver, loginPF);
            loginPF.Username.SendKeys("maciek");
            #region Password
            loginPF.Password.SendKeys("password_maciekte");
            #endregion
            loginPF.ClickOnLoginButton();
            Thread.Sleep(8000);
            driver.Quit();

        }
    }
}
