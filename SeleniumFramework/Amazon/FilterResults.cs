using SeleniumFramework.Amazon;

namespace SeleniumFramework.Pages
{
    public class FilterResultsPage
    {
        public void ClickDontChangeButton()
        {
            Common.Click(Locators.FilterResultsPage.DontChangeButton);
        }

        public void ClickGiftCardsLink()
        {
            Common.Click(Locators.FilterResultsPage.GiftCardsLink);
        }

        public void ClickAmazonGiftCardsFilter()
        {
            Common.Click(Locators.FilterResultsPage.AmazonGiftCardsFilter);
        }

        public bool VerifyResultsDisplayed()
        {
            return Common.WaitForElementToBeVisible(Locators.FilterResultsPage.ResultsText);
        }
    }
}
