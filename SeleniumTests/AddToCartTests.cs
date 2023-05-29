using NUnit.Framework;
using SeleniumFramework.Amazon;

namespace SeleniumTests
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
