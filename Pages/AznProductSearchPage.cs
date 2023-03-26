using AmazonTest.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest.Pages
{
    public class AznProductSearchPage
    {
        private readonly IWebDriver _webDriver;


        public AznProductSearchPage(IWebDriver webDriver) 
        { 
            _webDriver= webDriver;
        }


        #region WebElement

        public IWebElement txtSearch => _webDriver.FindElementPresence(By.Id("twotabsearchtextbox"));
        public IWebElement btnSearch => _webDriver.FindElementPresence(By.Id("nav-search-submit-button"));
        public IWebElement drpDwnSortBy => _webDriver.FindElementPresence(By.XPath("//span[normalize-space()='Sort by:']"));

        #endregion


        public void openWebPage()
        {
            _webDriver.Manage().Window.Maximize();

            _webDriver.Navigate().GoToUrl("https://www.amazon.com.au/");
        }

        public void applyFilter(string filterType,string filterCondition)
        {

            _webDriver.FindElementPresence(By.XPath
                ($"//span[contains(normalize-space(),'{filterType}')]" +
                $"/../following-sibling::ul//span[normalize-space()='{filterCondition}']//div//i"))
                .Click();
       
        
        }

        public void applySortFilter(string sortFilter)
        {
            drpDwnSortBy.Click();
            _webDriver.FindElementPresence(By.XPath($"//a[text()='{sortFilter}']")).Click();

        }

    }
}
