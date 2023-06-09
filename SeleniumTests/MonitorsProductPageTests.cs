﻿using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumFramework.Amazon.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.MonitorsProductPageTests
{
    public class ProductMonitorsTest : BaseTest
    {
        [Test]
        public void VerifyMonitorsProductDetailsPage()
        {
            var monitorsProductPage = new MonitorsProductPage();

            Common.WaitForElementToBeVisible(Locators.ProductDetails.AllLinkLocator);
            monitorsProductPage.NavigateToCategory(Locators.ProductDetails.AllLinkLocator);
            Common.WaitForElementToBeVisible(Locators.ProductDetails.ComputersCategoryLocator);
            monitorsProductPage.NavigateToCategory(Locators.ProductDetails.ComputersCategoryLocator);
            Common.WaitForElementToBeVisible(Locators.ProductDetails.MonitorsCategoryLocator);
            monitorsProductPage.NavigateToCategory(Locators.ProductDetails.MonitorsCategoryLocator);
            monitorsProductPage.SelectProduct(Locators.ProductDetails.FirstSearchProductLocator);

            Assert.IsTrue(monitorsProductPage.IsPageElementVisible(Locators.ProductDetails.ProductTitleLocator));
        }
    }
}