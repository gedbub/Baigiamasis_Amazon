namespace SeleniumFramework.Amazon
{
    public class MonitorsProduct
    {
        public static void NavigateToCategory(string categoryLocator)
        {
            Common.WaitForElementToBeVisible(categoryLocator);
            Common.Click(categoryLocator);
        }

        public static void SelectProduct(string productLocator)
        {
            Common.WaitForElementToBeVisible(productLocator);
            Common.Click(productLocator);
        }

        public static bool IsPageElementVisible(string elementLocator)
        {
            return Common.WaitForElementToBeVisible(elementLocator);
        }
    }
}
