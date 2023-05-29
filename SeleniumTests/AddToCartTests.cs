using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class AddToCartTests : BaseTest
    {
        [Test]
        public void AddItemToCart()
        {
            ProductSearch.EnterSearchTerm("iphone");
            AddToCart.SubmitSearch();
            AddToCart.SelectFirstProduct();
            AddToCart.AddProductToCart();
            Assert.IsTrue(AddToCart.VerifyItemAdded());
        }
    }
}
