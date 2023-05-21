using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class AddToCartTests : BaseTest
    {
        private AddToCart addToCart;
        private ProductSearch productSearch;

        [SetUp]
        public void Setup()
        {
            productSearch = new ProductSearch();
            addToCart = new AddToCart();
        }

        [Test]
        public void AddItemToCart()
        {
            productSearch.EnterSearchTerm("iphone");
            addToCart.SubmitSearch();
            addToCart.SelectFirstProduct();
            addToCart.AddProductToCart();
            Assert.IsTrue(addToCart.VerifyItemAdded());
        }
    }
}
