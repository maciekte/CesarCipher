using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AgitoTest
{
    public static class Parameters
    {
        public static string AgitoURL = "https://www.emag.pl/";
        public static By searchInputBoxClass = By.CssSelector("[class='searchbox-main gtm_search_bar_click_search_week js-searchbox-input']");
        public static string searchButtonClass = "btn btn-default searchbox-submit-button";
    }
}


