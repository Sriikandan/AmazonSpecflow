using AmazonTest.Drivers;
using AmazonTest.Pages;
using OpenQA.Selenium.DevTools.V109.Network;
using System;
using TechTalk.SpecFlow;

namespace AmazonTest.StepDefinitions
{
    [Binding]
    public class AznProductSearchStepDefinitions

    {

        private readonly AznProductSearchPage _AznProductSearchPage;

        public AznProductSearchStepDefinitions(BrowserDriver browserDriver)
        {
            _AznProductSearchPage = new AznProductSearchPage(browserDriver.Current);
        }

        [Given(@"I open the Amazon to Buy a product")]
        public void GivenIOpenTheAmazonToBuyAProduct()
        {
            _AznProductSearchPage.openWebPage();
        }

        [Given(@"I enter the product to be searched as (.*)")]
        public void GivenIEnterTheProductToBeSearchedAs(string searchProduct)
        {

            _AznProductSearchPage.txtSearch.SendKeys(searchProduct);    
        }

        [Given(@"I click on the search")]
        public void GivenIClickOnTheSearch()
        {
            _AznProductSearchPage.btnSearch.Click();
        }

        [Given(@"I apply search filter by (.*) with criteria as (.*)")]
        public void GivenIApplySearchFilterByWithCriteriaAs(string brand, string type)
        {
            _AznProductSearchPage.applyFilter(brand, type);
        }
        

        [Given(@"I will apply sort by (.*)")]
        public void GivenIWillApplySortBy(string sortFilter)
        {
            _AznProductSearchPage.applySortFilter(sortFilter);
        }
    }
}
