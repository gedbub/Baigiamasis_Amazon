namespace SeleniumFramework.Amazon
{
    public class MonitorsProduct
    {
        public static void OpenMenuAll()
        {
            Common.WaitForElementToBeVisibleAndClick(Locators.ProductDetails.AllLinkLocator);
        }

        public static void ExpandMenuComputers()
        {
            Common.WaitForElementToBeVisibleAndClick(Locators.ProductDetails.ComputersCategoryLocator);
        }

        public static void ExpandMenuMonitors()
        {
            Common.WaitForElementToBeVisibleAndClick(Locators.ProductDetails.MonitorsCategoryLocator);
        }

        public static void SelectFirstProduct()
        {
            Common.WaitForElementToBeVisibleAndClick(Locators.ProductDetails.FirstSearchProductLocator);
        }

        public static bool IsPageElementVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.ProductDetails.ProductTitleLocator);
        }
    }
}
