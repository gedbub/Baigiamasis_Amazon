using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class ProductSearch : BaseTest
    {
        [Test]
        public void SearchProduct()
        {
            Common.SendKeys(Locators.ProductSearch.SearchInput, "iPhone");
            Assert.IsTrue(Common.WaitForElementToBeVisible(Locators.ProductSearch.AutocompleteResult));
            Common.Click(Locators.ProductSearch.FirstAutocompleteResult);
            Assert.IsTrue(Common.WaitForElementToBeVisible(Locators.ProductSearch.SearchResultItem));
        }
    }
}
