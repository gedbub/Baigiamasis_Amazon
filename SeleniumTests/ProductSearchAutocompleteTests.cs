using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class ProductSearchAutocompleteTests : BaseTest
    {
        [Test]
        public void SearchProduct()
        {
            ProductSearch.EnterSearchTerm("iPhone");
            Assert.IsTrue(ProductSearch.IsAutocompleteResultVisible());
            ProductSearch.SelectFirstAutocompleteResult();
            Assert.IsTrue(ProductSearch.IsSearchResultVisible());
        }
    }
}
