using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class ProductSearchAutocompleteTests : BaseTest
    {
        private ProductSearch productSearch;

        [SetUp]
        public void Setup()
        {
            productSearch = new ProductSearch();
        }

        [Test]
        public void SearchProduct()
        {
            productSearch.EnterSearchTerm("iPhone");
            Assert.IsTrue(productSearch.IsAutocompleteResultVisible());
            productSearch.SelectFirstAutocompleteResult();
            Assert.IsTrue(productSearch.IsSearchResultVisible());
        }
    }
}
