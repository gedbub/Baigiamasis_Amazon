using SeleniumFramework.Amazon;

namespace SeleniumFramework.Pages
{
    public class AddToCart
    {
        public void SelectFirstProduct()
        {
            Common.Click(Locators.ProductDetails.FirstProductLocator);
        }

        public void AddProductToCart()
        {
            Common.Click(Locators.ProductDetails.AddToCartButton);
        }

        public bool VerifyItemAdded()
        {
            return Common.WaitForElementToBeVisible(Locators.ProductDetails.CartConfirmation);
        }

        public void SubmitSearch()
        {
            Common.Click(Locators.ProductSearch.SearchButton);
        }
    }
}
