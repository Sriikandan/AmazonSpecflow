using AmazonTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest.Extensions
{
    public static class WebDriverExtemsion
    {

        public static IWebElement FindElementPresence(this IWebDriver driver,By by)
        {

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(15);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            /* Ignore the exception - NoSuchElementException that indicates that the element is not present */
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement element = fluentWait.Until(x => x.FindElement(by));
            return element;

        }

    }
}

