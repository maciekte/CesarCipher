using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    class ReadOnlyColl_exercise
    {
        [Test]
        public void WikiSearch()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            driver.Manage().Window.Maximize();

            List<string> centralLanguages = new List<string>();
            ReadOnlyCollection<IWebElement> languages = driver.FindElements(By.ClassName("central-featured-lang"));
            foreach(IWebElement language in languages)
            {
                string lang = language.Text;
                lang = lang.Substring(0, lang.LastIndexOf("\r"));
                centralLanguages.Add(lang); 
            }
            string stop = "";

            SelectElement selectLanguage = new SelectElement(driver.FindElement(By.Id("searchLanguage")));
            selectLanguage.SelectByText("Polski");

            driver.Quit();


            //List<string> textofanchors = new List<string>();
            //ReadOnlyCollection<IWebElement> anchorLists = driver.FindElements(By.TagName("a"));
            //foreach (IWebElement anchor in anchorLists)
            //{
            //    if (anchor.Text.Length > 0)
            //    {
            //        textofanchors.Add(anchor.Text);
            //    }
            //}
            //string stop = "";
        }

    }
}
