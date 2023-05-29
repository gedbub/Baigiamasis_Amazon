namespace SeleniumFramework.Amazon
{
    public class FilterResults
    {
        public static void ClickDontChangeButton()
        {
            Common.Click(Locators.FilterResultsPage.DontChangeButton);
        }

        public static void ClickGiftCardsLink()
        {
            Common.Click(Locators.FilterResultsPage.GiftCardsLink);
        }

        public static void ClickAmazonGiftCardsFilter()
        {
            Common.Click(Locators.FilterResultsPage.AmazonGiftCardsFilter);
        }

        public static bool VerifyResultsDisplayed()
        {
            return Common.WaitForElementToBeVisible(Locators.FilterResultsPage.ResultsText);
        }
    }
}
