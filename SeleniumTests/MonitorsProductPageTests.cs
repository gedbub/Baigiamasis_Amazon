using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.MonitorsProductPageTests
{
    public class ProductMonitorsTest : BaseTest
    {
        [Test]
        public void VerifyMonitorsProductDetailsPage()
        {
            Common.WaitForElementToBeVisible(Locators.ProductDetails.AllLinkLocator);
            Common.Click(Locators.ProductDetails.AllLinkLocator);
            Common.WaitForElementToBeVisible(Locators.ProductDetails.ComputersCategoryLocator);
            Common.Click(Locators.ProductDetails.ComputersCategoryLocator);
            Common.WaitForElementToBeVisible(Locators.ProductDetails.MonitorsCategoryLocator);
            Common.Click(Locators.ProductDetails.MonitorsCategoryLocator);
            Common.WaitForElementToBeVisible(Locators.ProductDetails.FirstProductLocator);
            Common.Click(Locators.ProductDetails.FirstProductLocator);
            Assert.IsTrue(Common.WaitForElementToBeVisible(Locators.ProductDetails.ProductTitleLocator));
        }
    }
}
