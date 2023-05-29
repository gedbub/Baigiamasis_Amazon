using NUnit.Framework;
using SeleniumFramework;
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
            MonitorsProduct.NavigateToCategory(Locators.ProductDetails.AllLinkLocator);
            Common.WaitForElementToBeVisible(Locators.ProductDetails.ComputersCategoryLocator);
            MonitorsProduct.NavigateToCategory(Locators.ProductDetails.ComputersCategoryLocator);
            Common.WaitForElementToBeVisible(Locators.ProductDetails.MonitorsCategoryLocator);
            MonitorsProduct.NavigateToCategory(Locators.ProductDetails.MonitorsCategoryLocator);
            MonitorsProduct.SelectProduct(Locators.ProductDetails.FirstSearchProductLocator);

            Assert.IsTrue(MonitorsProduct.IsPageElementVisible(Locators.ProductDetails.ProductTitleLocator));
        }
    }
}