using SeleniumFramework;

namespace SeleniumFramework.Amazon.Pages
{
    public class MonitorsProductPage
    {
        public void NavigateToCategory(string categoryLocator)
        {
            Common.WaitForElementToBeVisible(categoryLocator);
            Common.Click(categoryLocator);
        }

        public void SelectProduct(string productLocator)
        {
            Common.WaitForElementToBeVisible(productLocator);
            Common.Click(productLocator);
        }

        public bool IsPageElementVisible(string elementLocator)
        {
            return Common.WaitForElementToBeVisible(elementLocator);
        }
    }
}
