namespace SeleniumFramework.Amazon
{
    public class AddToCart
    {
        public static void SelectFirstProduct()
        {
            Common.Click(Locators.ProductDetails.FirstProductLocator);
        }

        public static void AddProductToCart()
        {
            Common.Click(Locators.ProductDetails.AddToCartButton);
        }

        public static bool VerifyItemAdded()
        {
            return Common.WaitForElementToBeVisible(Locators.ProductDetails.CartConfirmation);
        }

        public static void SubmitSearch()
        {
            Common.Click(Locators.ProductSearch.SearchButton);
        }
    }
}
