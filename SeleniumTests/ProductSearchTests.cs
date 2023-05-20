using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.ProductSearchTests
{
    public class ProductSearchTests : BaseTest
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
