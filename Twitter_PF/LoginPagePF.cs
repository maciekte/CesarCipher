using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Twitter_PF
{
    class LoginPagePF
    {
        [FindsBy(How = How.CssSelector, Using = "[class='js-username-field email-input js-initial-focus']")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-password-field")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.ClassName, Using = "submit EdgeButton EdgeButton--primary EdgeButtom--medium")]
        public IWebElement login_button { get; set; }

        public void ClickOnLoginButton()
        {
            login_button.Click();
        }

    }
}
